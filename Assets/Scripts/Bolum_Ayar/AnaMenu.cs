using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// BATUHAN OZTURK 25.10.16
// BATUHAN OZTURK 05.12.16
// BATUHAN OZTURK 17.01.17

public class AnaMenu : MonoBehaviour {

    public static bool OyunMenu_OyunIciMenuKapatma;

    private GameObject KameradanScripte;
    int BaslangicBolum;
    
    float sure;
    bool SoldanSagaSwipeMagazaBug;
    bool DoubleBackStart;
    public GameObject OneMoreTimeToExit, ShopIco, SettingsIco;
    float BackSuresi;
    int CikisSayac;

    public static bool MenuSwipeSoldanSaga;
    public static bool MenuSwipeSagdanSola;

    public static bool Bolum1OzelSwipeIcoDevreDisi;

    public static bool CanMenuAcilirsaSureAyar;
    public static bool CanMenuKapama;

    public GameObject ParaMenu,CanMenu,Para, Can;

    public static int Bolum;

    // Ana Menu
    public GameObject SettingsShopBG;
    public Animator MenuSwipe,AyarlarMagazaBG,SettingsButon,ShopButon,Shop1,Shop2;
    public Text Title,Select_Stage, TouchToContinue,Money,Health;


    // SETTINGS BOLUMU
    public GameObject AyarlarPaneli;
    public Animator AyarAnim;
    public Toggle MusicToggle, FxToggle, Indicator;
    public static int MusicSes;
    public static int FxSes;
    public static int Gosterge;


    // SHOP BOLUMU
    public GameObject ShopPanel;
    public Animator ShopAnim;

    public static bool AnaMenuSonradanDonulurse; // Oyun içerisinde ana menüye gelirse kaldığın yerden resume olayı

    bool ResumeIkenStageSelectCanAzalt;
    
    void Start()
    {
        OyunMenu_OyunIciMenuKapatma = false;

        sure = 2.0f;
        SoldanSagaSwipeMagazaBug = false;
        CikisSayac = 0;
        BackSuresi = 2.1f;
        DoubleBackStart = false;
        OneMoreTimeToExit.SetActive(false);
        ShopIco.SetActive(true);
        SettingsIco.SetActive(true);

        MenuSwipeSoldanSaga = false;
        MenuSwipeSagdanSola = false;

        ResumeIkenStageSelectCanAzalt = false;

        CanMenuAcilirsaSureAyar = false;
        CanMenuKapama = false;

        CanMenu.SetActive(true);
        ParaMenu.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.SetActive(false);

        AnaMenuSonradanDonulurse = false;
        SettingsShopBG.SetActive(false);

        ShopPanel.SetActive(false);
        AyarlarPaneli.SetActive(false);

        MusicSes = PlayerPrefs.GetInt("MusicOn");
        FxSes = PlayerPrefs.GetInt("FxOn");
        Gosterge = PlayerPrefs.GetInt("IndicatorOn");


        OyuncuAyar.MoreHealth = PlayerPrefs.GetInt("MoreHealthMenu");
        if (OyuncuAyar.MoreHealth == 1)
        {
            Retry_CanKalmadi_MoreHealth();
        }


        if (MusicSes < 1) {

            MusicToggle.isOn = true;

        }
        else
        {
            if (MusicSes == 1)
            {
                MusicToggle.isOn = true;
            }
            else if (MusicSes == 2)
            {
                MusicToggle.isOn = false;
            }
        }


        if (FxSes < 1)
        {
            FxToggle.isOn = true;
        }
        else
        {
            if (FxSes == 1)
            {
                FxToggle.isOn = true;
            }
            else if (FxSes == 2)
            {
                FxToggle.isOn = false;
            }
        }

        if (Gosterge == 1)
        {
            Indicator.isOn = true;
        }
        else
        {
            Indicator.isOn = false;
        }

        if (StgNew.AnaMenuDonus_HealthMagazaAcilis)
        {
            Invoke("StagedenCanSatinAlimOK", 0.25f);
        }
        else if (StgNew.AnaMenuDonus_MoneyMagazaAcilis)
        {
            Invoke("StagedenParaSatinAlimOK", 0.25f);
        }

        if (MenuSwipeAyar.CanYokSwipeStart)
        {
            Invoke("StagedenCanSatinAlimOK",0);
            MenuSwipeAyar.CanYokSwipeStart = false;
        }

    }
    void StagedenCanSatinAlimOK()
    {
        Magaza();
        CanMenu.SetActive(true);
        ParaMenu.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.SetActive(false);


        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Button>().interactable = false;
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(1).gameObject.GetComponent<Button>().interactable = true;
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(2).gameObject.GetComponent<Button>().interactable = true;
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(3).gameObject.GetComponent<Button>().interactable = true;
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(4).gameObject.GetComponent<Button>().interactable = true;
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(5).gameObject.GetComponent<Button>().interactable = true;
    }
    void StagedenParaSatinAlimOK()
    {
        Magaza();
        ParaMenu.SetActive(true);
        CanMenu.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.SetActive(false);


        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Button>().interactable = true;
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(1).gameObject.GetComponent<Button>().interactable = true;
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(2).gameObject.GetComponent<Button>().interactable = true;
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(3).gameObject.GetComponent<Button>().interactable = true;
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(4).gameObject.GetComponent<Button>().interactable = true;
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(5).gameObject.GetComponent<Button>().interactable = false;
    }

	void Update ()
    {
        transform.GetChild(6).gameObject.transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().preserveAspect = true;

        OyuncuAyar.Can = PlayerPrefs.GetInt("Can");
        OyuncuAyar.Para = PlayerPrefs.GetInt("Para");

        MusicSes = PlayerPrefs.GetInt("MusicOn");
        FxSes = PlayerPrefs.GetInt("FxOn");
        Gosterge = PlayerPrefs.GetInt("IndicatorOn");

        Money.text = OyuncuAyar.Para.ToString();

        if (OyuncuAyar.SinirsizCan != 1)
        {
            Health.text = OyuncuAyar.Can.ToString();
        }
        else
        {
            Health.text = "∞";
        }

    transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = OyuncuAyar.Para.ToString();

        if (OyuncuAyar.SinirsizCan != 1)
        {
            transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = OyuncuAyar.Can.ToString();
        }
        else
        {
            transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "∞";
        }

        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().fontSize = Screen.width / 16;
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().fontSize = Screen.width / 16;

        Bolum = PlayerPrefs.GetInt("OyuncuHangiBolumdeKaldi");
        if (!AyarlarPaneli.activeInHierarchy)
        {
                if (MusicSes < 1)
                {

                    MusicToggle.isOn = true;

                }
                else
                {
                    if (MusicSes == 1)
                    {
                    MusicToggle.isOn = true;
                    }
                    else if (MusicSes == 2)
                    {
                    MusicToggle.isOn = false;
                    }
                }


                if (FxSes < 1)
                {
                    FxToggle.isOn = true;
                }
                else
                {
                    if (FxSes == 1)
                    {
                    FxToggle.isOn = true;
                    }
                    else if (FxSes == 2)
                    {
                    FxToggle.isOn = false;
                    }
                }

                if (Gosterge == 1)
                {
                    Indicator.isOn = true;
                }
                else
                {
                    Indicator.isOn = false;
                }
        }
        else {
            if (MusicToggle.isOn)
            {
                MusicSes = 1;
                PlayerPrefs.SetInt("MusicOn", MusicSes);
            }
            else
            {
                MusicSes = 2;
                PlayerPrefs.SetInt("MusicOn", MusicSes);
            }

            if (FxToggle.isOn)
            {
                FxSes = 1;
                PlayerPrefs.SetInt("FxOn", FxSes);
            }
            else
            {
                FxSes = 2;
                PlayerPrefs.SetInt("FxOn", FxSes);
            }

            if (Indicator.isOn)
            {
                Gosterge = 1;
                PlayerPrefs.SetInt("IndicatorOn", Gosterge);
            }
            else
            {
                Gosterge = 0;
                PlayerPrefs.SetInt("IndicatorOn", Gosterge);
            }
        }

        if (!AnaMenuSonradanDonulurse) {

            ResumeIkenStageSelectCanAzalt = false;

            TouchToContinue.fontSize = Screen.width / 14;

            if (Bolum == 1)
            {
                TouchToContinue.text = "STAGE  " + Bolum.ToString() + "\nSwipe To Start";
            }
            else
            {
                if (Bolum != 151) { 
                TouchToContinue.text = "STAGE  " + Bolum.ToString() + "\nSwipe To Continue";
                }
                else
                {
               TouchToContinue.text = "STAGE  " + Bolum.ToString() + "\nComing Soon";
                }
            }
        }
        else
        {
            ResumeIkenStageSelectCanAzalt = true;
            TouchToContinue.fontSize = Screen.width / 15;
            TouchToContinue.text = "STAGE  " + Bolum.ToString() + "\nSwipe To Resume";
        }

        Title.fontSize = Screen.width / 6;
        Title.text = "BALL-E";

        Select_Stage.fontSize = Screen.width / 17;
        Select_Stage.text = "Select Stage";

        Money.fontSize = Screen.width / 16;
		Health.fontSize = Screen.width / 16;

        // Ayarlar Menu Basligi
        transform.GetChild(6).gameObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.GetComponent<Text>().fontSize = Screen.width / 12;
        // Ayarlar Menusu Music Text
  transform.GetChild(6).gameObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().fontSize = Screen.width / 15;
        // Ayarlar Menusu Fx Text
  transform.GetChild(6).gameObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().fontSize = Screen.width / 15;    
        // Ayarlar Menusu Indicator Text
  transform.GetChild(6).gameObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().fontSize = Screen.width / 15;
        

        // Magaza Menusu Basligi
  transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.GetComponent<Text>().fontSize = Screen.width / 15;
        // Magaza Menusu 25 GOLD
  transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 18;
        // Magaza Menusu 60 GOLD
  transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 18;

        for (int i = 2; i<=6;i++)
        {    
        // Magaza Menusu GOLDLAR 1000-2500..
transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 18;
        }

        for (int i = 2; i <= 4; i++)
        {
        // Magaza Menusu GOLDLAR BUY 1000-2500..
            transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 18;

            transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 18;
        }

            // Magaza Menusu 25 GOLD Free
            transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).GetComponent<Text>().fontSize = Screen.width / 14;
        // Magaza Menusu 60 GOLD Free
transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).GetComponent<Text>().fontSize = Screen.width / 14;
        // Magaza Menusu 60 GOLD Free ADS - 2
transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).GetComponent<Text>().fontSize = Screen.width / 25;

        for (int i = 5; i<=9; i++) {

            if (i != 9)
            {
                transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 18;
            }
            else
            {
                transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 18;
            }
         }

        for (int i = 5; i<=8; i++)
        {
transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 18;
        }

        for (int i = 2; i <= 6; i++) { 
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 18;
            transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 18;
        }

        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(1).gameObject.SetActive(true);

            for (int i = 0; i < 2; i++)
            {
                transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.GetComponent<Button>().interactable = false;
            }
            for (int i = 2; i <= 4; i++)
            {
                transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(1).gameObject.GetComponent<Button>().interactable = false;
            }
            for (int i = 5; i <= 8; i++)
            {
                transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.GetComponent<Button>().interactable = false;
            }

            transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(1).gameObject.GetComponent<Button>().interactable = false;

        }
        else
        {
            transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(1).gameObject.SetActive(false);

            for (int i = 0; i < 2; i++)
            {
                transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.GetComponent<Button>().interactable = true;
            }
            for (int i = 2; i <= 4; i++)
            {
                transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(1).gameObject.GetComponent<Button>().interactable = true;
            }
            for (int i = 5; i <= 8; i++)
            {
                transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.GetComponent<Button>().interactable = true;
            }

            transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(1).gameObject.GetComponent<Button>().interactable = true;
        }
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 20;


        transform.GetChild(6).gameObject.transform.GetChild(0).gameObject.transform.GetChild(7).gameObject.GetComponent<Text>().fontSize = Screen.width / 20;

        if (Input.GetKeyDown(KeyCode.Escape) && transform.GetChild(6).gameObject.activeInHierarchy)
        {
            if (MenuSwipeAyar.tch == 100)
            {
                if (ShopPanel.activeInHierarchy)
                {
                    if (ParaMenu.activeInHierarchy)
                    {
                        MagazaKapat();
                    }
                    else
                    {
                        CanMenuKapama = true;
                        MagazaKapat();
                    }
                }

                if (AyarlarPaneli.activeInHierarchy)
                {
                    AyarlarKapat();
                }
            }

                if (!SettingsShopBG.activeInHierarchy)
                {
                    DoubleBackStart = true;
                    CikisSayac += 1;
                }
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && !transform.GetChild(6).gameObject.activeInHierarchy)
        {
            if (transform.GetChild(4).gameObject.activeInHierarchy)
            {
                if (!OyunMenu.ButonDisable) {
                    OyunIciMenuAnaMenu();
                    OyunMenu_OyunIciMenuKapatma = true;
                }
            }
        }

        if (DoubleBackStart)
        {
            if (BackSuresi > 0.0f)
            {
                BackSuresi -= Time.deltaTime;
            }
            if (BackSuresi > 0.25f && BackSuresi <= 2.08f)
            {
                OneMoreTimeToExit.SetActive(true);
                ShopIco.SetActive(false);
                SettingsIco.SetActive(false);

                if (CikisSayac == 2)
                {
                    //BATUHAN OZTURK 06.01.17
                    if (ResumeIkenStageSelectCanAzalt && OyuncuAyar.SinirsizCan != 1)
                    {
                        if (CharController1.TopHareketEttimi || CharController2.TopHareketEttimi || CharController3.TopHareketEttimi)
                        {
                            if (OyuncuAyar.Can > 0)
                            {
                                OyuncuAyar.Can--;
                                PlayerPrefs.SetInt("Can", OyuncuAyar.Can);
                            }
                        }
                    }
                    Application.Quit();
                }
            }
            else if (BackSuresi >= 0.15f && BackSuresi <= 0.25f)
            {
                OneMoreTimeToExit.SetActive(false);
                ShopIco.SetActive(true);
                SettingsIco.SetActive(true);
                CikisSayac = 0;
            }
            else if (BackSuresi < 0.15f)
            {
                DoubleBackStart = false;
                BackSuresi = 2.1f;
            }
        }

        if (MenuSwipeSoldanSaga && !ShopPanel.activeInHierarchy)
        {
            SoldanSagaSwipeMagazaBug = true;
            Invoke("Magaza",0.1f);
        }

        if (SoldanSagaSwipeMagazaBug)
        {
            if (sure > 0) {
                sure -= Time.deltaTime;
            }
        }
        
        if (MenuSwipeSagdanSola && !AyarlarPaneli.activeInHierarchy)
        {
            Invoke("Ayarlar", 0.1f);
        }

        if (AyarlarPaneli.activeInHierarchy || ShopPanel.activeInHierarchy)
        {
            MenuSwipeAyar.KaydirmaKilit = true;
            Bolum1OzelSwipeIcoDevreDisi = true;
        }
        else
        {
            MenuSwipeAyar.KaydirmaKilit = false;
        }      
    }


    public void StagesMenu()
    {
        if (ResumeIkenStageSelectCanAzalt && OyuncuAyar.SinirsizCan != 1)
        {
            if (CharController1.TopHareketEttimi || CharController2.TopHareketEttimi || CharController3.TopHareketEttimi)
            {
                if (OyuncuAyar.Can > 0)
                {
                    OyuncuAyar.Can--;
                    PlayerPrefs.SetInt("Can", OyuncuAyar.Can);
                }
            }
        }

        StgNew.HangiBolumdenGeldi = Bolum;

        if (MusicSes != 2) { 
        Canvas_BgMusic.StagesSelectGidis = true;
        }
        else
        {
            SceneManager.LoadScene("StageSelect");
        }
        
    }
    //
    // public void Para_1000()
    // {
    //   OyunIciSatinAlim.Instance.Buy1000Gold();
    // }
    // public void Para_2500()
    // {
    //   OyunIciSatinAlim.Instance.Buy2500Gold();
    // }
    // public void Unlimited_HP()
    // {
    //   OyunIciSatinAlim.Instance.BuyUnlimitedHP();
    // }
    // public void Unlimited_HardBallBlocker()
    // {
    //   OyunIciSatinAlim.Instance.BuyUnlimitedHardBallBlocker();
    // }
    // public void Unlimited_BallBlocker()
    // {
    //   OyunIciSatinAlim.Instance.BuyUnlimitedBallBlocker();
    // }
    // public void Unlimited_WallCreator()
    // {
    //   OyunIciSatinAlim.Instance.BuyUnlimitedWallCreator();
    // }
    // public void Unlimited_WallBreaker()
    // {
    //   OyunIciSatinAlim.Instance.BuyUnlimitedWallBreaker();
    // }
    // public void Reklamlari_Sil()
    // {
    //   OyunIciSatinAlim.Instance.BuyNoAds();
    // }

    public void Can_1Adet()
    {
        if (OyuncuAyar.SinirsizCan != 1) {
            if (OyuncuAyar.Para >= 25)
            {
                OyuncuAyar.Para -= 25;
                PlayerPrefs.SetInt("Para", OyuncuAyar.Para);

                OyuncuAyar.Can += 1;
                PlayerPrefs.SetInt("Can", OyuncuAyar.Can);
            }
            else
            {
                ButonOnayEksikPara();
            }
        }
    }
    public void Can_5Adet()
    {
        if (OyuncuAyar.SinirsizCan != 1)
        {
            if (OyuncuAyar.Para >= 125)
            {
                OyuncuAyar.Para -= 125;
                PlayerPrefs.SetInt("Para", OyuncuAyar.Para);

                OyuncuAyar.Can += 5;
                PlayerPrefs.SetInt("Can", OyuncuAyar.Can);
            }
            else
            {
                ButonOnayEksikPara();
            }
        }
    }
    public void Can_10Adet()
    {
        if (OyuncuAyar.SinirsizCan != 1)
        {
            if (OyuncuAyar.Para >= 250)
            {
                OyuncuAyar.Para -= 250;
                PlayerPrefs.SetInt("Para", OyuncuAyar.Para);

                OyuncuAyar.Can += 10;
                PlayerPrefs.SetInt("Can", OyuncuAyar.Can);
            }
            else
            {
                ButonOnayEksikPara();
            }
        }
    }
    public void Can_20Adet()
    {
        if (OyuncuAyar.SinirsizCan != 1)
        {
            if (OyuncuAyar.Para >= 500)
            {
                OyuncuAyar.Para -= 500;
                PlayerPrefs.SetInt("Para", OyuncuAyar.Para);

                OyuncuAyar.Can += 20;
                PlayerPrefs.SetInt("Can", OyuncuAyar.Can);
            }
            else
            {
                ButonOnayEksikPara();
            }
        }
    }
    public void Can_40Adet()
    {
        if (OyuncuAyar.SinirsizCan != 1)
        {
            if (OyuncuAyar.Para >= 1000)
            {
                OyuncuAyar.Para -= 1000;
                PlayerPrefs.SetInt("Para", OyuncuAyar.Para);

                OyuncuAyar.Can += 40;
                PlayerPrefs.SetInt("Can", OyuncuAyar.Can);
            }
            else
            {
                ButonOnayEksikPara();
            }
        }
    }

    void ButonOnayEksikPara()
    {
        ParaMenu.SetActive(true);
        CanMenu.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.SetActive(false);

        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Button>().interactable = true;
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(1).gameObject.GetComponent<Button>().interactable = true;
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(2).gameObject.GetComponent<Button>().interactable = true;
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(3).gameObject.GetComponent<Button>().interactable = true;
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(4).gameObject.GetComponent<Button>().interactable = true;
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(5).gameObject.GetComponent<Button>().interactable = false;
    }
    public void TekrarOynaOyunIciMenu()
    {
        if ((CharController1.TopHareketEttimi || CharController2.TopHareketEttimi || CharController3.TopHareketEttimi) && OyuncuAyar.SinirsizCan != 1)
        {
            if (OyuncuAyar.Can > 0)
            {          
                OyuncuAyar.Can--;
                PlayerPrefs.SetInt("Can", OyuncuAyar.Can);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            else
            {
                OyuncuAyar.MoreHealth = 1;
                PlayerPrefs.SetInt("MoreHealthMenu", OyuncuAyar.MoreHealth);

                AnaMenuyeDon();
            }
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        int x = Random.Range(0, 4);
        if (x == 0)
        {
            // Reklam.GecisReklami();
        }
    }

    public void AnaMenuyeDon()
    {
        // Reklam.GecisReklami();

        OyunBittiAnaMenuTekrarYukle();
    }

    void OyunBittiAnaMenuTekrarYukle()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        OyuncuAyar.Menu_isActive = 1;
        PlayerPrefs.SetInt("Menu_isActive", OyuncuAyar.Menu_isActive);

    }

    public void AnaMenu_MoreHPCoinClick()
    {
        SoldanSagaSwipeMagazaBug = true;
    }


    public void Magaza()
    {
        MenuSwipeAyar.tch = 100;

        Shop1.Play("ButonDisabled",-1,0f);
        Shop2.Play("ButonDisabled", -1, 0f);

        Para.SetActive(false);
        Can.SetActive(false);

        ShopButon.Play("ButonDevreDisi", -1, 0f);
        ShopPanel.SetActive(true);
        ShopAnim.Play("MagazaAcilis", -1, 0f);

        SettingsShopBG.SetActive(true);
    }
    public void MagazaKapat()
    {
        if (SoldanSagaSwipeMagazaBug)
        {
            if (sure < 0.2f)
            {
                MagazaKapatGecikme();
            }
        }
        else
        {
            Bolum1OzelSwipeIcoDevreDisi = false;
            MenuSwipeSoldanSaga = false;
            MenuSwipeSagdanSola = false;
            MenuSwipeAyar.tch = 0;

            ShopAnim.Play("MagazaKapanis", -1, 0f);
            Invoke("ShopPanelGizle", 1.0f);

            Para.SetActive(true);
            Can.SetActive(true);

            AyarlarMagazaBG.Play("AyarlarShopBG_Donus", -1, 0f);

            StgNew.AnaMenuDonus_MoneyMagazaAcilis = false;
            StgNew.AnaMenuDonus_HealthMagazaAcilis = false;

            Invoke("MagazaKapatilinca_MenuSekmeDefault", 1.0f);

        }
        
    }

    void MagazaKapatilinca_MenuSekmeDefault()
    {

        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Button>().interactable = false;
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(1).gameObject.GetComponent<Button>().interactable = true;
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(2).gameObject.GetComponent<Button>().interactable = true;
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(3).gameObject.GetComponent<Button>().interactable = true;
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(4).gameObject.GetComponent<Button>().interactable = true;
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.transform.GetChild(5).gameObject.GetComponent<Button>().interactable = true;

        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.SetActive(false);
    }

    void MagazaKapatGecikme()
    {
        Bolum1OzelSwipeIcoDevreDisi = false;
        MenuSwipeSoldanSaga = false;
        MenuSwipeSagdanSola = false;
        MenuSwipeAyar.tch = 0;

        ShopAnim.Play("MagazaKapanis", -1, 0f);
        Invoke("ShopPanelGizle", 1.0f);

        Para.SetActive(true);
        Can.SetActive(true);

        AyarlarMagazaBG.Play("AyarlarShopBG_Donus", -1, 0f);

        SoldanSagaSwipeMagazaBug = false;
        sure = 2.0f;

        Invoke("MagazaKapatilinca_MenuSekmeDefault", 1.0f);
    }

    void ShopPanelGizle()
    {
        ShopPanel.SetActive(false);
        SettingsShopBG.SetActive(false);
    }


    public void Ayarlar()
    {
        MenuSwipeAyar.tch = 100;

        SettingsButon.Play("ButonDevreDisi", -1, 0f);
        AyarlarPaneli.SetActive(true);
        AyarAnim.Play("AyarlarAcilis", -1, 0f);

        SettingsShopBG.SetActive(true);
    }

    public void AyarlarKapat()
    {
        Bolum1OzelSwipeIcoDevreDisi = false;
           MenuSwipeSoldanSaga = false;
        MenuSwipeSagdanSola = false;
        MenuSwipeAyar.tch = 0;
        AyarAnim.Play("AyarlarKapanis", -1, 0f);
        Invoke("AyarlarPanelGizle", 1.0f);

        AyarlarMagazaBG.Play("AyarlarShopBG_Donus", -1, 0f);

        StgNew.AnaMenuDonus_MoneyMagazaAcilis = false;
        StgNew.AnaMenuDonus_HealthMagazaAcilis = false;
    }
    void AyarlarPanelGizle()
    {
        AyarlarPaneli.SetActive(false);
        SettingsShopBG.SetActive(false);
    }

    void IslemleriYap()
    {

        MenuSwipe.Play("MenuPanel", -1, 0f);
        Invoke("BolumAyarlari", 1.1f);

    }

	public void KaldiginBolumdenDevam(){

        if (Bolum != 151)
        {

            if (OyuncuAyar.Can > 0 || OyuncuAyar.SinirsizCan == 1 || AnaMenuSonradanDonulurse)
            {
                IslemleriYap();
            }
            else
            {
                Magaza();
                CanMenu.SetActive(true);
                ParaMenu.SetActive(false);
                transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.SetActive(false);
                transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.SetActive(false);
                transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.SetActive(false);
                transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(6).gameObject.SetActive(false);
             }

        }

    }

  void BolumAyarlari()
    {
        AnaMenuSonradanDonulurse = false;

        OyuncuAyar.Menu_isActive = 0;
        PlayerPrefs.SetInt("Menu_isActive", OyuncuAyar.Menu_isActive);

    }

    public void OyunIciMenuAnaMenu()
    {
        if (!OyunMenu.ButonDisable)
        {
            AnaMenuSonradanDonulurse = true;

            OyuncuAyar.Menu_isActive = 1;
            PlayerPrefs.SetInt("Menu_isActive", OyuncuAyar.Menu_isActive);
        }
    }
    void BolumAyarlariAnaMenuDonusu()
    {
        AnaMenuSonradanDonulurse = true;

        OyuncuAyar.Menu_isActive = 1;
        PlayerPrefs.SetInt("Menu_isActive", OyuncuAyar.Menu_isActive);

    }
    public void AnaMenuMoreCoin()
    {
        BolumAyarlariAnaMenuDonusu();

        Para.SetActive(false);
        Can.SetActive(false);
            
        ShopPanel.SetActive(true);
        SettingsShopBG.SetActive(true);

        ParaMenu.SetActive(true);
        CanMenu.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(6).gameObject.SetActive(false);

        Invoke("GecikmeAnim",0.25f);

    }
    public void AnaMenuMoreHealth()
    {
        CanMenuAcilirsaSureAyar = true;
        BolumAyarlariAnaMenuDonusu();

        Para.SetActive(false);
        Can.SetActive(false);

        ShopPanel.SetActive(true);
        SettingsShopBG.SetActive(true);

        ParaMenu.SetActive(false);
        CanMenu.SetActive(true);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(6).gameObject.SetActive(false);

        Invoke("GecikmeAnim", 0.25f);
    }

    void Retry_CanKalmadi_MoreHealth()
    {
        CanMenuAcilirsaSureAyar = true;

        Para.SetActive(false);
        Can.SetActive(false);

        ShopPanel.SetActive(true);
        SettingsShopBG.SetActive(true);

        ParaMenu.SetActive(false);
        CanMenu.SetActive(true);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(6).gameObject.SetActive(false);

        Invoke("GecikmeAnim_2", 0.25f);
    }

    public void MoreHealthCanKalmadiginda()
    {
        if (OyuncuAyar.Can > 0 || OyuncuAyar.SinirsizCan == 1)
        {

        }
        else
        {
            OyuncuAyar.MoreHealth = 1;
            PlayerPrefs.SetInt("MoreHealthMenu", OyuncuAyar.MoreHealth);

            AnaMenuyeDon();
        }
    }

    void GecikmeAnim()
    {
        AnaMenuSonradanDonulurse = true;
        Shop1.Play("ButonDisabled", -1, 0f);
        Shop2.Play("ButonDisabled", -1, 0f);

        ShopButon.Play("ButonDevreDisi", -1, 0f);
        ShopAnim.Play("MagazaAcilis", -1, 0f);
    }

    void GecikmeAnim_2()
    {
        Shop1.Play("ButonDisabled", -1, 0f);
        Shop2.Play("ButonDisabled", -1, 0f);

        ShopButon.Play("ButonDevreDisi", -1, 0f);
        ShopAnim.Play("MagazaAcilis", -1, 0f);

        OyuncuAyar.MoreHealth = 0;
        PlayerPrefs.SetInt("MoreHealthMenu", OyuncuAyar.MoreHealth);
    }


    // Sosyal Medya
    public void Facebook()
    {
        float startTime;
        startTime = Time.timeSinceLevelLoad;

        Application.OpenURL("facebook://page/BallE.MobileGame/");

        if (Time.timeSinceLevelLoad - startTime <= 1f)
        {
            Application.OpenURL("https://www.facebook.com/BallE.MobileGame/");
        }
    }
    public void Twitter()
    {
        float startTime;
        startTime = Time.timeSinceLevelLoad;

        Application.OpenURL("twitter://user?user_id=FBRGames_BallE");

        if (Time.timeSinceLevelLoad - startTime <= 1f)
        {
            Application.OpenURL("https://twitter.com/FBRGames_BallE");
        }
    }
    public void Instagram()
    {
        float startTime;
        startTime = Time.timeSinceLevelLoad;

        Application.OpenURL("instagram://user?username=fbrgames.ball_e");

        if (Time.timeSinceLevelLoad - startTime <= 1f)
        {
            Application.OpenURL("https://www.instagram.com/fbrgames.ball_e/");
        }
    }
    public void Youtube()
    {
        float startTime;
        startTime = Time.timeSinceLevelLoad;

        Application.OpenURL("youtube://channel/UCBFVlFr176DQu75lb54XEZA");

        if (Time.timeSinceLevelLoad - startTime <= 1f)
        {
            Application.OpenURL("https://www.youtube.com/channel/UCBFVlFr176DQu75lb54XEZA");
        }
    }
    public void GooglePlus()
    {
        float startTime;
        startTime = Time.timeSinceLevelLoad;

        Application.OpenURL("googleplus://id/100870329106384503688");

        if (Time.timeSinceLevelLoad - startTime <= 1f)
        {
            Application.OpenURL("https://plus.google.com/u/0/100870329106384503688");
        }
    }
    public void Spotify()
    {
        float startTime;
        startTime = Time.timeSinceLevelLoad;

        Application.OpenURL("spotify://user/fbrgames");

        if (Time.timeSinceLevelLoad - startTime <= 1f)
        {
            Application.OpenURL("http://open.spotify.com/user/fbrgames");
        }
    }

}