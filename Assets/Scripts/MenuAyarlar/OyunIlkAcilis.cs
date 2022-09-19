using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

// BATUHAN OZTURK 24.12.16
 public class OyunIlkAcilis : MonoBehaviour {

  //  public GameObject LoadingScene;
    public Image LoadingBar;
    public Text textPourcentage;
    private Boolean estActive = false;
    AsyncOperation async = null;

    public Material First_Barrier_Material;
    public Material First_Grid_Material;
    public Material First_BorderBg_Material;

    public Color Gri_Grid_Renk,Kirmizi_Barrier_Renk, Mavi_BorderBg_Renk;

    public Text LoadingTxt;

    static int SonBolum = 151;

    string[] HangiBolumMenusu = new String[SonBolum];

    int Bolum_All;

    void Start (){

        OyuncuAyar.Menu_isActive = 1;
        PlayerPrefs.SetInt("Menu_isActive", OyuncuAyar.Menu_isActive);

        for (int Bolumler = 0; Bolumler < SonBolum; Bolumler++)
        {
            HangiBolumMenusu[Bolumler] = "Bolum" + (Bolumler + 1);
        }


        // *** //

        if (!PlayerPrefs.HasKey("SinirsizCan"))
        {
            OyuncuAyar.SinirsizCan = 0;
            PlayerPrefs.SetInt("SinirsizCan", OyuncuAyar.SinirsizCan);
        }
        else
        {
           OyuncuAyar.SinirsizCan = PlayerPrefs.GetInt("SinirsizCan");
        }

        if (!PlayerPrefs.HasKey("SinirsizHardBallLocker"))
        {
            OyuncuAyar.SinirsizHardBallBlocker = 0;
            PlayerPrefs.SetInt("SinirsizHardBallLocker", OyuncuAyar.SinirsizHardBallBlocker);
        }
        else
        {
            OyuncuAyar.SinirsizHardBallBlocker = PlayerPrefs.GetInt("SinirsizHardBallLocker");
        }


        if (!PlayerPrefs.HasKey("SinirsizBallLocker"))
        {
            OyuncuAyar.SinirsizBallBlocker = 0;
            PlayerPrefs.SetInt("SinirsizBallLocker", OyuncuAyar.SinirsizBallBlocker);
        }
        else
        {
            OyuncuAyar.SinirsizBallBlocker = PlayerPrefs.GetInt("SinirsizBallLocker");
        }


        if (!PlayerPrefs.HasKey("SinirsizWallCreator"))
        {
            OyuncuAyar.SinirsizWallCreator = 0;
            PlayerPrefs.SetInt("SinirsizWallCreator", OyuncuAyar.SinirsizWallCreator);
        }
        else
        {
            OyuncuAyar.SinirsizWallCreator = PlayerPrefs.GetInt("SinirsizWallCreator");
        }


        if (!PlayerPrefs.HasKey("SinirsizWallBreaker"))
        {
            OyuncuAyar.SinirsizWallBreaker = 0;
            PlayerPrefs.SetInt("SinirsizWallBreaker", OyuncuAyar.SinirsizWallBreaker);
        }
        else
        {
            OyuncuAyar.SinirsizWallBreaker = PlayerPrefs.GetInt("SinirsizWallBreaker");
        }

        if (!PlayerPrefs.HasKey("Barrier_Renk_0"))
        {
            for (int i = 0; i <= 8; i++)
            {
                if (i == 0)
                {
                    PlayerPrefs.SetInt("Barrier_Renk_" + i.ToString(), 1);
                }
                else
                {
                    PlayerPrefs.SetInt("Barrier_Renk_" + i.ToString(), 0);
                }
            }
        }

        if (!PlayerPrefs.HasKey("Grid_Renk_0"))
        {
            for (int i = 0; i <= 8; i++)
            {
                if (i == 0)
                {
                    PlayerPrefs.SetInt("Grid_Renk_" + i.ToString(), 1);
                }
                else
                {
                    PlayerPrefs.SetInt("Grid_Renk_" + i.ToString(), 0);
                }
            }
        }

        if (!PlayerPrefs.HasKey("Bg_Renk_0"))
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    PlayerPrefs.SetInt("Bg_Renk_" + i.ToString(), 1);
                }
                else
                {
                    PlayerPrefs.SetInt("Bg_Renk_" + i.ToString(), 0);
                }
            }
        }

        if (!PlayerPrefs.HasKey("Border_Renk_0"))
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    PlayerPrefs.SetInt("Border_Renk_" + i.ToString(), 1);
                }
                else
                {
                    PlayerPrefs.SetInt("Border_Renk_" + i.ToString(), 0);
                }
            }
        }

        if (!PlayerPrefs.HasKey("Mevcut_BariyerRengi"))
        {
            First_Barrier_Material.color = Kirmizi_Barrier_Renk;
            PlayerPrefs.SetInt("Mevcut_BariyerRengi", 0);
        }

        if (!PlayerPrefs.HasKey("Mevcut_IzgaraRengi"))
        {
            First_Grid_Material.color = Gri_Grid_Renk;
            PlayerPrefs.SetInt("Mevcut_IzgaraRengi", 0);
        }

        if (!PlayerPrefs.HasKey("Mevcut_BorderRengi"))
        {
            First_BorderBg_Material.color = Mavi_BorderBg_Renk;
            PlayerPrefs.SetInt("Mevcut_BorderRengi", 0);
        }

        if (!PlayerPrefs.HasKey("Mevcut_BackgroundRengi"))
        {
            PlayerPrefs.SetInt("Mevcut_BackgroundRengi", 0);
        }

        if (!PlayerPrefs.HasKey("xHour"))
        {
            Time_HP.Hour = DateTime.Now.Hour;
            Time_HP.Day = DateTime.Now.Day;
            Time_HP.Month = DateTime.Now.Month;
            Time_HP.Year = DateTime.Now.Year;

            PlayerPrefs.SetInt("xHour", Time_HP.Hour);
            PlayerPrefs.SetInt("xDay", Time_HP.Day);
            PlayerPrefs.SetInt("xMonth", Time_HP.Month);
            PlayerPrefs.SetInt("xYear", Time_HP.Year);
        }

        if (!PlayerPrefs.HasKey("OyunaIlkDefaMiGirildi")) { 
        Canvas_BgMusic.OyunaIlkDefaMiGirildi = 0;
        PlayerPrefs.SetInt("OyunaIlkDefaMiGirildi", Canvas_BgMusic.OyunaIlkDefaMiGirildi);
        }

        if (!PlayerPrefs.HasKey("MoreHealthMenu"))
        {
            OyuncuAyar.MoreHealth = 0;
            PlayerPrefs.SetInt("MoreHealthMenu", OyuncuAyar.MoreHealth);
        }

        if (!PlayerPrefs.HasKey("Can") && OyuncuAyar.SinirsizCan != 1)
        {
            OyuncuAyar.Can = 10;
            PlayerPrefs.SetInt("Can", OyuncuAyar.Can);
        }

        if (!PlayerPrefs.HasKey("Para"))
        {
            OyuncuAyar.Para = 0;
            PlayerPrefs.SetInt("Para", OyuncuAyar.Para);
        }

        if (!PlayerPrefs.HasKey("HardBallLockerKullanimHakki") && OyuncuAyar.SinirsizHardBallBlocker != 1)
        {
            OyuncuAyar.HardBallLockerKullanim = 3;
            PlayerPrefs.SetInt("HardBallLockerKullanimHakki", OyuncuAyar.HardBallLockerKullanim);
        }

        if (!PlayerPrefs.HasKey("BallLockerKullanimHakki") && OyuncuAyar.SinirsizBallBlocker != 1)
        {
            OyuncuAyar.BallLockerKullanim = 3;
            PlayerPrefs.SetInt("BallLockerKullanimHakki", OyuncuAyar.BallLockerKullanim);
        }

        if (!PlayerPrefs.HasKey("WallCreatorKullanimHakki") && OyuncuAyar.SinirsizWallCreator != 1)
        {
            OyuncuAyar.WallCreatorKullanim = 3;
            PlayerPrefs.SetInt("WallCreatorKullanimHakki", OyuncuAyar.WallCreatorKullanim);
        }

        if (!PlayerPrefs.HasKey("WallBreakerKullanimHakki") && OyuncuAyar.SinirsizWallBreaker != 1)
        {
            OyuncuAyar.WallBreakerKullanim = 3;
            PlayerPrefs.SetInt("WallBreakerKullanimHakki", OyuncuAyar.WallBreakerKullanim);
        }

        if (!PlayerPrefs.HasKey("NoADS"))
        {
            OyuncuAyar.ReklamKalkti = 0;
            PlayerPrefs.SetInt("NoADS", OyuncuAyar.ReklamKalkti);
        }

        // if (!PlayerPrefs.HasKey("ReklamGosterimineBasla"))
        // {
        //     Reklam.ReklamGosterimineBasla = 0;
        //     PlayerPrefs.SetInt("ReklamGosterimineBasla", Reklam.ReklamGosterimineBasla);
        // }


       if (PlayerPrefs.HasKey("OyuncuHangiBolumdeKaldi"))
        {
            AnaMenu.Bolum = PlayerPrefs.GetInt("OyuncuHangiBolumdeKaldi");
            StgNew.OyuncununGectigiBolumler = PlayerPrefs.GetInt("OyuncununGectigiBolumler");

            if (AnaMenu.Bolum >= StgNew.OyuncununGectigiBolumler)
            {
                StgNew.OyuncununGectigiBolumler = AnaMenu.Bolum;
                PlayerPrefs.SetInt("OyuncununGectigiBolumler", StgNew.OyuncununGectigiBolumler);
            }

            Canvas_BgMusic.OyunaIlkDefaMiGirildi = 1;
            PlayerPrefs.SetInt("OyunaIlkDefaMiGirildi", Canvas_BgMusic.OyunaIlkDefaMiGirildi);
        }
        else
        {
			// AnaMenu Bolum 1 olacak test için 150 yazıldı
            AnaMenu.Bolum = 1;
            PlayerPrefs.SetInt("OyuncuHangiBolumdeKaldi", AnaMenu.Bolum);
        }

        MenuSwipeAyar.KaydirmaKilit = false;

        if (StgNew.OyuncununGectigiBolumler >= 1)
        {
            for (int BolumlerGecilen = 1; BolumlerGecilen <= 151; BolumlerGecilen++)
            {
                if (StgNew.OyuncununGectigiBolumler == BolumlerGecilen)
                {
                    ChargementScene(HangiBolumMenusu[BolumlerGecilen - 1]);
                }
            }
        }
        else
        {
            for (int BolumlerGecilmeyen = 1; BolumlerGecilmeyen <= 151; BolumlerGecilmeyen++)
            {
                if (AnaMenu.Bolum == BolumlerGecilmeyen)
                {
                    ChargementScene(HangiBolumMenusu[BolumlerGecilmeyen - 1]);
                }
            }
        }
    }

   void Update () {

        if (estActive)
        {
            StartCoroutine(LevelCoroutine());

        }

        LoadingTxt.fontSize = Screen.width / 17;
        textPourcentage.fontSize = Screen.width / 21;

      }

    void ChargementScene(String nom)
    {
        estActive = true;
    //    LoadingScene.SetActive(true);
        async = SceneManager.LoadSceneAsync(nom);
        async.allowSceneActivation = false; //  On demande à unity d'attendre et de ne pas activer automatiquement la scène.
    }

    IEnumerator LevelCoroutine()
    {

        float pourcentage = 0;
        while (!async.isDone)
        {
            if (async.progress < 0.9f)
            {
                LoadingBar.fillAmount = async.progress / 0.9f;
                pourcentage = async.progress * 100;
                textPourcentage.text = (int)pourcentage + "%";
            }
            else
            {
                LoadingBar.fillAmount = async.progress / 0.9f;
                pourcentage = (async.progress / 0.9f) * 100;
                textPourcentage.text = (int)pourcentage + "%";
                async.allowSceneActivation = true;
            }

            yield return null;
        }


        yield return async;

    }
}
