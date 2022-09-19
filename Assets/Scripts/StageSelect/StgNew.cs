using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class StgNew : MonoBehaviour {

    public Sprite Blue_Dotted, Green_Dotted, Orange_Dotted, Red_Dotted, Yellow_Dotted;

    public Color Standart_BorderColor, Green, Orange, Red, Yellow;
    public Material BorderBg;


    int Background_Code, BorderBg_Code;

    AudioSource SesKaynak;
    public AudioClip[] BgSesler;

    public static int HangiBolumdenGeldi;

    public static int HangiSarkiSecildi;
    public static float HangiSarkiveSaniyesi;

    public static bool StagesdenGelis;

    public static int OyuncununGectigiBolumler;
    public static bool AnaMenuDonus_HealthMagazaAcilis, AnaMenuDonus_MoneyMagazaAcilis;

    public static string BolumAdNe;

    public GameObject stgs;

    int x;

    float Min_x,Max_x, Min_y, Max_y;

    int BolumSayi;

    string BolumNo_String;

    int BolumKilitNu;

    void Start ()
    {
        x = 2;
        OyuncununGectigiBolumler = PlayerPrefs.GetInt("OyuncununGectigiBolumler");
        Background_Code = PlayerPrefs.GetInt("Mevcut_BackgroundRengi");
        BorderBg_Code = PlayerPrefs.GetInt("Mevcut_BorderRengi");

        SesKaynak = GetComponent<AudioSource>();

        SesKaynak.volume = 0.0f;

        switch (HangiSarkiSecildi)
        {
            case 0:
                SesKaynak.clip = BgSesler[0];
                SesKaynak.time = HangiSarkiveSaniyesi;
                SesKaynak.Play();
                break;
            case 1:
                SesKaynak.clip = BgSesler[1];
                SesKaynak.time = HangiSarkiveSaniyesi;
                SesKaynak.Play();
                break;
            case 2:
                SesKaynak.clip = BgSesler[2];
                SesKaynak.time = HangiSarkiveSaniyesi;
                SesKaynak.Play();
                break;
        }

        Canvas_BgMusic.StagesSelectGidis = false;

        AnaMenuDonus_HealthMagazaAcilis = false;
        AnaMenuDonus_MoneyMagazaAcilis = false;

        StagesdenGelis = false;

        BolumSayi = 0;

        Min_y = 0.778f;
        Max_y = 0.8776f;

        Min_x = 0.01f;
        Max_x = 0.034f;

        for (int i = 0; i < 151; i++)
        {
            if (i != 0)
            {
                GameObject OlusanObje = Instantiate(stgs, stgs.transform.position, stgs.transform.rotation) as GameObject;
                OlusanObje.transform.parent = GameObject.Find("Canvas_StageSelect/Panel/ScrollAlani").transform;

                Min_y -= 0.162f;
                Max_y -= 0.162f;

                if (i % 5 == 0)
                {
                    Min_x += 0.03205f;
                    Max_x += 0.03205f;

                    Min_y = 0.778f;
                    Max_y = 0.8776f;
                }

                OlusanObje.GetComponent<RectTransform>().anchorMin = new Vector2(Min_x, Min_y);
                OlusanObje.GetComponent<RectTransform>().anchorMax = new Vector2(Max_x, Max_y);

                OlusanObje.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
                OlusanObje.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);

            }
            else
            {
                GameObject OlusanObje = Instantiate(stgs, stgs.transform.position, stgs.transform.rotation) as GameObject;
                OlusanObje.transform.parent = GameObject.Find("Canvas_StageSelect/Panel/ScrollAlani").transform;

                OlusanObje.GetComponent<RectTransform>().anchorMin = new Vector2(0.01f, 0.778f);
                OlusanObje.GetComponent<RectTransform>().anchorMax = new Vector2(0.034f, 0.8776f);

                OlusanObje.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
                OlusanObje.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
            }

            
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = (BolumSayi += 1).ToString();
            
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.name = "Bolum" + BolumSayi.ToString();

        }

        switch (Background_Code)
        {
            case 0:
             GameObject.Find("ArkaPlan").GetComponent<SpriteRenderer>().sprite = Blue_Dotted;
                break;

            case 1:
             GameObject.Find("ArkaPlan").gameObject.GetComponent<SpriteRenderer>().sprite = Green_Dotted;
                break;

            case 2:
                GameObject.Find("ArkaPlan").gameObject.GetComponent<SpriteRenderer>().sprite = Orange_Dotted;
                break;
            case 3:
                GameObject.Find("ArkaPlan").gameObject.GetComponent<SpriteRenderer>().sprite = Red_Dotted;
                break;

            case 4:
                GameObject.Find("ArkaPlan").gameObject.GetComponent<SpriteRenderer>().sprite = Yellow_Dotted;
                break;

            default:
                GameObject.Find("ArkaPlan").gameObject.GetComponent<SpriteRenderer>().sprite = Blue_Dotted;
                break;
        }


          switch (BorderBg_Code)
             {
           case 0:
                BorderBg.color = Standart_BorderColor;
                break;
            case 1:
                BorderBg.color = Green;
                break;
            case 2:
                BorderBg.color = Orange;
                break;
            case 3:
                BorderBg.color = Red;
                break;
            case 4:
                BorderBg.color = Yellow;
                break;
       }

    }


    void Update ()
    {
        OyuncununGectigiBolumler = PlayerPrefs.GetInt("OyuncununGectigiBolumler");    

        OyuncuAyar.SinirsizCan = PlayerPrefs.GetInt("SinirsizCan");
        OyuncuAyar.Can = PlayerPrefs.GetInt("Can");
        OyuncuAyar.Para = PlayerPrefs.GetInt("Para");

        transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = OyuncuAyar.Para.ToString();

        if (OyuncuAyar.SinirsizCan != 1) { 
        transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = OyuncuAyar.Can.ToString();
        }
        else
        {
            transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "∞";
        }

       transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().fontSize = Screen.width / 15;
       transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().fontSize = Screen.width / 15;

        AnaMenu.Bolum = PlayerPrefs.GetInt("OyuncuHangiBolumdeKaldi");
        OyuncununGectigiBolumler = PlayerPrefs.GetInt("OyuncununGectigiBolumler");

        if (OyuncununGectigiBolumler < AnaMenu.Bolum)
        {
            OyuncununGectigiBolumler = AnaMenu.Bolum;
            PlayerPrefs.SetInt("OyuncununGectigiBolumler", OyuncununGectigiBolumler);
        }

        AnaMenu.MusicSes = PlayerPrefs.GetInt("MusicOn");

        if (AnaMenu.MusicSes != 2)
        {
            SesKaynak.UnPause();
            if (SesKaynak.volume < 1.0f)
            {
                SesKaynak.volume += 0.01f;
            }

        }
        else
        {
            SesKaynak.Pause();
            SesKaynak.volume = 0.0f;
        }

        if (StagesdenGelis)
        {
            Canvas_BgMusic.StagesdenGelisSarki = HangiSarkiSecildi;
            Canvas_BgMusic.StagesdenGelisSure = SesKaynak.time;

            if (SesKaynak.volume > 0.0f)
            {
                SesKaynak.volume -= 0.05f;

                if (SesKaynak.volume < 0.1f)
                {
                    if (x == 0)
                    {
                        SceneManager.LoadScene("Bolum" + HangiBolumdenGeldi.ToString());
                    }
                    else
                    {
                        SceneManager.LoadScene(BolumAdNe);
                    }
                }
            }

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MainMenu();
        }
    }
    public void MainMenu()
    {
        if (AnaMenu.MusicSes != 2)
        {
            x = 0;

            StagesdenGelis = true;
        }
        else
        {
            SceneManager.LoadScene("Bolum" + HangiBolumdenGeldi.ToString());
        }
    }

    public void BlmBtn()
    {
        var btn = EventSystem.current.currentSelectedGameObject;

        BolumNo_String = btn.name.Substring(5, btn.name.Length - 5);

        BolumNumarasi(int.Parse(BolumNo_String));

        BolumSecimi(btn.name);
    }

    public void BolumNumarasi(int BolumNo)
    {
        if (OyuncuAyar.Can > 0 || OyuncuAyar.SinirsizCan == 1 || BolumNo == 151)
        {
            AnaMenuDonus_HealthMagazaAcilis = false;

            if (OyuncununGectigiBolumler > BolumNo)
            {
                OyuncuAyar.BolumPlayCount = 2;
                PlayerPrefs.SetInt("BolumuDahaOnceOynadi", OyuncuAyar.BolumPlayCount);
            }
            AnaMenu.Bolum = BolumNo;
            PlayerPrefs.SetInt("OyuncuHangiBolumdeKaldi", AnaMenu.Bolum);

            if (BolumNo != 151)
            {
                OyuncuAyar.Menu_isActive = 0;
                PlayerPrefs.SetInt("Menu_isActive", OyuncuAyar.Menu_isActive);
            }
            else
            {
                OyuncuAyar.Menu_isActive = 1;
                PlayerPrefs.SetInt("Menu_isActive", OyuncuAyar.Menu_isActive);
            }

            if (AnaMenu.Bolum == 1)
            {
                AnaMenu.Bolum1OzelSwipeIcoDevreDisi = true;
            }
        }
        else
        {
            AnaMenuDonus_HealthMagazaAcilis = true;
            SceneManager.LoadScene("Bolum" + HangiBolumdenGeldi.ToString());
        }
    }

    public void BolumSecimi(string BolumAdi)
    {
        if (OyuncuAyar.Can > 0 || OyuncuAyar.SinirsizCan == 1 || BolumAdi == "Bolum151")
        {
            if (AnaMenu.MusicSes != 2)
            {    
                StagesdenGelis = true;
                x = 1;

                BolumAdNe = BolumAdi;
            }
            else
            {
                SceneManager.LoadScene(BolumAdi);
            }
        }
    }


    public void DahaFazlaCan()
    {
        AnaMenuDonus_HealthMagazaAcilis = true;
        AnaMenuDonus_MoneyMagazaAcilis = false;

        if (AnaMenu.MusicSes != 2)
        {
            x = 0;

            StagesdenGelis = true;
        }
        else
        {
            SceneManager.LoadScene("Bolum" + HangiBolumdenGeldi.ToString());
        }
    }
    public void DahaFazlaPara()
    {
        AnaMenuDonus_MoneyMagazaAcilis = true;
        AnaMenuDonus_HealthMagazaAcilis = false;

        if (AnaMenu.MusicSes != 2)
        {
            x = 0;

            StagesdenGelis = true;
        }
        else
        {
            SceneManager.LoadScene("Bolum" + HangiBolumdenGeldi.ToString());
        }
    }
}
