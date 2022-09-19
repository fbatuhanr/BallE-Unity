using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu_Ses_Efekt : MonoBehaviour {

    AudioSource SesKaynagi;
    public AudioClip[] SoundFXS;

    public static bool StaticCikis;

    void Start()
    {
        SesKaynagi = GetComponent<AudioSource>();
        SesKaynagi.volume = 0.5f;
        StaticCikis = false;
    }

    public static void RastgeleEfektSesi()
    {
        StaticCikis = true;
    }

    void Update()
    {
        AnaMenu.FxSes = PlayerPrefs.GetInt("FxOn");
        SesKaynagi.volume = 0.5f;

        if (StaticCikis)
        {
            Invoke("Olay",0);
            StaticCikis = false;
        }
    }

    void Olay()
    {
        if (AnaMenu.FxSes != 2)
        {
            int RastgeleSes = Random.Range(1, 4);
            switch (RastgeleSes)
            {
                case 1:
                    SesKaynagi.PlayOneShot(SoundFXS[0], 1);
                    break;
                case 2:
                    SesKaynagi.PlayOneShot(SoundFXS[1], 1);
                    break;
                case 3:
                    SesKaynagi.PlayOneShot(SoundFXS[2], 1);
                    break;
            }
        }
    }

}
