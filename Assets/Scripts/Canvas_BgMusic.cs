using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Canvas_BgMusic : MonoBehaviour {

    AudioSource SesKaynagi;
    public AudioClip[] BgMusics;

    public static int StagesdenGelisSarki;
    public static float StagesdenGelisSure;

    public static bool DurdurmaMenuAcildi_BgMusicKes, StagesSelectGidis;

    public static int OyunaIlkDefaMiGirildi;

	void Start () {

        SesKaynagi = GetComponent<AudioSource>();

        SesKaynagi.volume = 0.0f;

        DurdurmaMenuAcildi_BgMusicKes = false;

        StagesSelectGidis = false;

        OyunaIlkDefaMiGirildi = PlayerPrefs.GetInt("OyunaIlkDefaMiGirildi");

        // Baslangic
        if (!StgNew.StagesdenGelis) {

            if (OyunaIlkDefaMiGirildi == 1) { 
                int RastgeleBaslangicBGSound = Random.Range(0, 3);

                StgNew.HangiSarkiSecildi = RastgeleBaslangicBGSound;

                switch (RastgeleBaslangicBGSound)
                {
                    case 0:
                        SesKaynagi.clip = BgMusics[0];
                        SesKaynagi.Play();
                        break;
                    case 1:
                        SesKaynagi.clip = BgMusics[1];
                        SesKaynagi.Play();
                        break;
                    case 2:
                        SesKaynagi.clip = BgMusics[2];
                        SesKaynagi.Play();
                        break;
                }
            }
            else
            {
                StgNew.HangiSarkiSecildi = 1;

                SesKaynagi.clip = BgMusics[1];
                SesKaynagi.Play();


                OyunaIlkDefaMiGirildi = 1;
                PlayerPrefs.SetInt("OyunaIlkDefaMiGirildi", OyunaIlkDefaMiGirildi);
            }
        }
        else
        {
            int HangiSarki = StagesdenGelisSarki;
            switch (HangiSarki)
            {
                case 0:
                    SesKaynagi.clip = BgMusics[0];
                    SesKaynagi.time = StagesdenGelisSure;
                    SesKaynagi.Play();
                    break;
                case 1:
                    SesKaynagi.clip = BgMusics[1];
                    SesKaynagi.time = StagesdenGelisSure;
                    SesKaynagi.Play();
                    break;
                case 2:
                    SesKaynagi.clip = BgMusics[2];
                    SesKaynagi.time = StagesdenGelisSure;
                    SesKaynagi.Play();
                    break;
            }
        }
    }
	
	void Update () {

        AnaMenu.MusicSes = PlayerPrefs.GetInt("MusicOn");

        if (AnaMenu.MusicSes != 2) {
            if (SesKaynagi.volume < 1.0f && !DurdurmaMenuAcildi_BgMusicKes)
            {
                SesKaynagi.volume += 0.01f;
                SesKaynagi.UnPause();
            }
            else if (SesKaynagi.volume > 0.0f && DurdurmaMenuAcildi_BgMusicKes)
            {
                SesKaynagi.volume -= 0.01f;

                if (SesKaynagi.volume < 0.1f)
                {
                    SesKaynagi.Pause();
                }
            }
        }
        else
        {
            if (SesKaynagi.volume > 0.0f)
            {
                SesKaynagi.volume -= 0.05f;

                if (SesKaynagi.volume < 0.1f)
                {
                    SesKaynagi.Pause();
                }
            }
         }


        if (StagesSelectGidis)
        {
            StgNew.HangiSarkiveSaniyesi = SesKaynagi.time;

            if (SesKaynagi.volume > 0.0f) { 

                SesKaynagi.volume -= 0.05f;

                if (SesKaynagi.volume < 0.1f)
                {
                    SceneManager.LoadScene("StageSelect");
                }
            }
        }


    }

}
