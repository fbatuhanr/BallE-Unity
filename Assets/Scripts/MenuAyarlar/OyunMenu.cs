using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class OyunMenu : MonoBehaviour {

    public Material GridKayma;
    float Grid_y;

    // *_* *_* *_*

    static int KarakterlerinHareketHakki;

    // *_* *_* *_*

    // *_* *_* *_*
    string BolumNo;
public static int BolumNumarasi;
public static int Baslangic_MoveHakki, Tamamlandi_MoveHakki;
    bool GecikmeliSwipe;
    // *_* *_* *_*


    GameObject YesilTop_HardBarrier, YesilTop_Barrier;
    GameObject SariTop_HardBarrier, SariTop_Barrier;
    GameObject MaviTop_HardBarrier, MaviTop_Barrier;

    public Text HardBallLockerTxt, BallLockerTxt, WallCreatorTxt, WallBreakerTxt;
    public Text HBL_5Txt, BL_3Txt, HBL_KullanimHakkiTxt, BL_KullanimHakkiTxt, WC_KullanimHakkiTxt, WB_KullanimHakkiTxt;
    public static int HBL_5, BL_3;

    public Text RemoverBallLockerTxt, Infinity1Txt;

    float timer;
    bool timerStart;

    public static bool KarakterHareketGostergeAktif;

    bool GameOver_HealtMinusOne;

    public static bool Karakterler_IsTrigger;

    public Toggle Music, SoundFX, Indicator;

    public GameObject OyunBittiPaneli, OyunBittiBG, BolumTamamlandiPanel, MenuOyunIciPanelBG, MenuOyunIci;
    public Text Count, Money, Health, TryAgain, MissionPassed, PausedText,MusicText,SoundFXText,IndicatorText;
    public Animator DevamEt, OyunIciMenuIcon, OyunIciMenuBG, OyunIciMenusu, HareketCountTextAnim, GoldCountTextAnim;
    public static bool BolumGecildi;
    public static bool YesilKapi, SariKapi, MaviKapi;

    string BolumYukle;

    public static bool OyunBaslangiciGecikme;

    float Zamanlayici;

    float ToplarAsagi;

    public static int SayacUp;

    public static bool BgUstveAltAnim;

    public static int MenuAcildimi;

    // OyunTamamlandi
    bool KalanHareketiParayaAta;
    bool Tespit;

    bool SwipeIcinAyarlarMenuAcildiKontrol;

    bool BolumTamamlanincaPauseMenuAcma;

    public static bool ButonDisable;

    void GecikmeliSwipeEtkin()
    {
        if (BolumNumarasi <= 25)
        {
            CharController1.SwipeDisabled = false;
            CharController2.SwipeDisabled = false;
        }
        else
        {
            CharController1.SwipeDisabled = false;
            CharController2.SwipeDisabled = false;
            CharController3.SwipeDisabled = false;
        }
    }

    void Start()
    {
        Scene MevcutSahne = SceneManager.GetActiveScene();
        BolumNo = MevcutSahne.name.Substring(5, (MevcutSahne.name.Length-5));
        BolumNumarasi = int.Parse(BolumNo);

        AnaMenu.Bolum = BolumNumarasi;
        PlayerPrefs.SetInt("OyuncuHangiBolumdeKaldi", AnaMenu.Bolum);

        BolumYukle = "Bolum"+(BolumNumarasi + 1);

        GecikmeliSwipe = false;

        Grid_y = 1.0f;
        GridKayma.mainTextureOffset = new Vector2(0.3f, 1.0f);

        if (BolumNumarasi > 0 && BolumNumarasi <= 10)
        {
            Count.text = "∞";
        }
        else if (BolumNumarasi > 10 && BolumNumarasi <= 15)
        {
            KarakterlerinHareketHakki = 25;
        }
        else if (BolumNumarasi > 15 && BolumNumarasi <= 19)
        {
            KarakterlerinHareketHakki = 20;
        }
        else
        {
            switch (BolumNumarasi)
            {
                case 20:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 21:
                    KarakterlerinHareketHakki = 25;
                    break;
                case 22:
                    KarakterlerinHareketHakki = 25;
                    break;
                case 23:
                    KarakterlerinHareketHakki = 20;
                    break;
                case 24:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 25:
                    KarakterlerinHareketHakki = 25;
                    break;
                case 26:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 27:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 28:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 29:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 30:
                    KarakterlerinHareketHakki = 25;
                    break;
                case 31:
                    KarakterlerinHareketHakki = 40;
                    break;
                case 32:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 33:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 34:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 35:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 36:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 37:
                    KarakterlerinHareketHakki = 40;
                    break;
                case 38:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 39:
                    KarakterlerinHareketHakki = 40;
                    break;
                case 40:
                    KarakterlerinHareketHakki = 40;
                    break;
                case 41:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 42:
                    KarakterlerinHareketHakki = 40;
                    break;
                case 43:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 44:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 45:
                    KarakterlerinHareketHakki = 40;
                    break;
                case 46:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 47:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 48:
                    KarakterlerinHareketHakki = 40;
                    break;
                case 49:
                    KarakterlerinHareketHakki = 50;
                    break;
                case 50:
                    KarakterlerinHareketHakki = 50;
                    break;
                case 51:
                    KarakterlerinHareketHakki = 40;
                    break;
                case 52:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 53:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 54:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 55:
                    KarakterlerinHareketHakki = 40;
                    break;
                case 56:
                    KarakterlerinHareketHakki = 40;
                    break;
                case 57:
                    KarakterlerinHareketHakki = 20;
                    break;
                case 58:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 59:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 60:
                    KarakterlerinHareketHakki = 50;
                    break;
                case 61:
                    KarakterlerinHareketHakki = 40;
                    break;
                case 62:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 63:
                    KarakterlerinHareketHakki = 45;
                    break;
                case 64:
                    KarakterlerinHareketHakki = 40;
                    break;
                case 65:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 66:
                    KarakterlerinHareketHakki = 25;
                    break;
                case 67:
                    KarakterlerinHareketHakki = 40;
                    break;
                case 68:
                    KarakterlerinHareketHakki = 50;
                    break;
                case 69:
                    KarakterlerinHareketHakki = 25;
                    break;
                case 70:
                    KarakterlerinHareketHakki = 50;
                    break;
                case 71:
                    KarakterlerinHareketHakki = 25;
                    break;
                case 72:
                    KarakterlerinHareketHakki = 40;
                    break;
                case 73:
                    KarakterlerinHareketHakki = 50;
                    break;
                case 74:
                    KarakterlerinHareketHakki = 50;
                    break;
                case 75:
                    KarakterlerinHareketHakki = 25;
                    break;
                case 76:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 77:
                    KarakterlerinHareketHakki = 25;
                    break;
                case 78:
                    KarakterlerinHareketHakki = 50;
                    break;
                case 79:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 80:
                    KarakterlerinHareketHakki = 50;
                    break;
                case 81:
                    KarakterlerinHareketHakki = 45;
                    break;
                case 82:
                    KarakterlerinHareketHakki = 25;
                    break;
                case 83:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 84:
                    KarakterlerinHareketHakki = 20;
                    break;
                case 85:
                    KarakterlerinHareketHakki = 20;
                    break;
                case 86:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 87:
                    KarakterlerinHareketHakki = 12;
                    break;
                case 88:
                    KarakterlerinHareketHakki = 25;
                    break;
                case 89:
                    KarakterlerinHareketHakki = 50;
                    break;
                case 90:
                    KarakterlerinHareketHakki = 40;
                    break;
                case 91:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 92:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 93:
                    KarakterlerinHareketHakki = 25;
                    break;
                case 94:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 95:
                    KarakterlerinHareketHakki = 10;
                    break;
                case 96:
                    KarakterlerinHareketHakki = 25;
                    break;
                case 97:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 98:
                    KarakterlerinHareketHakki = 40;
                    break;
                case 99:
                    KarakterlerinHareketHakki = 45;
                    break;
                case 100:
                    KarakterlerinHareketHakki = 45;
                    break;
                case 101:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 102:
                    KarakterlerinHareketHakki = 25;
                    break;
                case 103:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 104:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 105:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 106:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 107:
                    KarakterlerinHareketHakki = 50;
                    break;
                case 108:
                    KarakterlerinHareketHakki = 40;
                    break;
                case 109:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 110:
                    KarakterlerinHareketHakki = 15;
                    break;
                case 111:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 112:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 113:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 114:
                    KarakterlerinHareketHakki = 40;
                    break;
                case 115:
                    KarakterlerinHareketHakki = 15;
                    break;
                case 116:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 117:
                    KarakterlerinHareketHakki = 40;
                    break;
                case 118:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 119:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 120:
                    KarakterlerinHareketHakki = 40;
                    break;
                case 121:
                    KarakterlerinHareketHakki = 25;
                    break;
                case 122:
                    KarakterlerinHareketHakki = 20;
                    break;
                case 123:
                    KarakterlerinHareketHakki = 40;
                    break;
                case 124:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 125:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 126:
                    KarakterlerinHareketHakki = 25;
                    break;
                case 127:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 128:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 129:
                    KarakterlerinHareketHakki = 20;
                    break;
                case 130:
                    KarakterlerinHareketHakki = 40;
                    break;
                case 131:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 132:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 133:
                    KarakterlerinHareketHakki = 25;
                    break;
                case 134:
                    KarakterlerinHareketHakki = 25;
                    break;
                case 135:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 136:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 137:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 138:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 139:
                    KarakterlerinHareketHakki = 25;
                    break;
                case 140:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 141:
                    KarakterlerinHareketHakki = 25;
                    break;
                case 142:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 143:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 144:
                    KarakterlerinHareketHakki = 30;
                    break;
                case 145:
                    KarakterlerinHareketHakki = 25;
                    break;
                case 146:
                    KarakterlerinHareketHakki = 25;
                    break;
                case 147:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 148:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 149:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 150:
                    KarakterlerinHareketHakki = 35;
                    break;
                case 151:
                    //coming soon
                    KarakterlerinHareketHakki = 999;
                    break;
            }
        }

        Baslangic_MoveHakki = KarakterlerinHareketHakki;

        if (BolumNumarasi == 1) { 
            if (StgNew.OyuncununGectigiBolumler >= 1)
            {
                transform.GetChild(7).gameObject.SetActive(false);
            }
            else
            {
                transform.GetChild(7).gameObject.SetActive(true);
            }
        }

        if (BolumNumarasi > 0 && BolumNumarasi <= 25) {

            if (BolumNumarasi <= 20)
            {
                CharController1.YukariGidisDeger = 1.2f;    CharController1.AsagiGidisDeger = -1.2f;   CharController1.SolaGidisDeger = -1.2f;    CharController1.SagaGidisDeger = 1.2f;
                CharController2.YukariGidisDeger = 1.2f;   CharController2.AsagiGidisDeger = -1.2f;   CharController2.SolaGidisDeger = -1.2f;    CharController2.SagaGidisDeger = 1.2f;
            }
            else if (BolumNumarasi > 20 && BolumNumarasi <= 25)
            {
                CharController1.YukariGidisDeger = 0.9f;  CharController1.AsagiGidisDeger = -0.9f;  CharController1.SolaGidisDeger = -0.9f; CharController1.SagaGidisDeger = 0.9f;
                CharController2.YukariGidisDeger = 0.9f; CharController2.AsagiGidisDeger = -0.9f;  CharController2.SolaGidisDeger = -0.9f; CharController2.SagaGidisDeger = 0.9f;
            }
            CharController1.CharControlSag1 = true; CharController1.CharControlSol1 = true; CharController1.CharControlAsagi1 = true; CharController1.CharControlYukari1 = true;
            CharController2.CharControlSag2 = true; CharController2.CharControlSol2 = true;  CharController2.CharControlAsagi2 = true; CharController2.CharControlYukari2 = true;
        }
        else {
            if (BolumNumarasi > 25 && BolumNumarasi <= 43)
            {
                CharController1.YukariGidisDeger = 0.9f;    CharController1.AsagiGidisDeger = -0.9f;   CharController1.SolaGidisDeger = -0.9f;  CharController1.SagaGidisDeger = 0.9f;
                CharController2.YukariGidisDeger = 0.9f;  CharController2.AsagiGidisDeger = -0.9f;   CharController2.SolaGidisDeger = -0.9f; CharController2.SagaGidisDeger = 0.9f;
                CharController3.YukariGidisDeger = 0.9f;  CharController3.AsagiGidisDeger = -0.9f;  CharController3.SolaGidisDeger = -0.9f; CharController3.SagaGidisDeger = 0.9f;
            }
            else if (BolumNumarasi > 43)
            {
                CharController1.YukariGidisDeger = 0.8f;  CharController1.AsagiGidisDeger = -0.8f;  CharController1.SolaGidisDeger = -0.8f; CharController1.SagaGidisDeger = 0.8f;
                CharController2.YukariGidisDeger = 0.8f;   CharController2.AsagiGidisDeger = -0.8f;  CharController2.SolaGidisDeger = -0.8f; CharController2.SagaGidisDeger = 0.8f;
                CharController3.YukariGidisDeger = 0.8f;  CharController3.AsagiGidisDeger = -0.8f;    CharController3.SolaGidisDeger = -0.8f;  CharController3.SagaGidisDeger = 0.8f;
            }
            CharController1.CharControlSag1 = true; CharController1.CharControlSol1 = true;   CharController1.CharControlAsagi1 = true;  CharController1.CharControlYukari1 = true;
            CharController2.CharControlSag2 = true;  CharController2.CharControlSol2 = true;   CharController2.CharControlAsagi2 = true;   CharController2.CharControlYukari2 = true;
            CharController3.CharControlSag3 = true; CharController3.CharControlSol3 = true;   CharController3.CharControlAsagi3 = true;  CharController3.CharControlYukari3 = true;
        }
 

        ButonDisable = false;

        timer = 2.7f;
        timerStart = false;

        KarakterHareketGostergeAktif = true;

        GameOver_HealtMinusOne = false;

        Karakterler_IsTrigger = true;

        BolumTamamlanincaPauseMenuAcma = false;
        SwipeIcinAyarlarMenuAcildiKontrol = false; // Çünkü PAUSE menü açılmadı

        Tespit = false;

        KalanHareketiParayaAta = false;

        MenuOyunIci.SetActive(false);
        MenuOyunIciPanelBG.SetActive(false);

        BgUstveAltAnim = false;

        MenuAcildimi = 0;

        Zamanlayici = 0.0f;

        ToplarAsagi = 2.0f;

        OyunBaslangiciGecikme = true;

        BolumGecildi = false;
        YesilKapi = false;
        SariKapi = false;
        MaviKapi = false;

        OyunBittiPaneli.SetActive(false);
        OyunBittiBG.SetActive(false);
        BolumTamamlandiPanel.SetActive(false);
        
    }
    void KarakterHareketDevreDisi() {

        CharController1.CharControlSag1 = false;
        CharController1.CharControlSol1 = false;
        CharController1.CharControlAsagi1 = false;
        CharController1.CharControlYukari1 = false;

        CharController2.CharControlSag2 = false;
        CharController2.CharControlSol2 = false;
        CharController2.CharControlAsagi2 = false;
        CharController2.CharControlYukari2 = false;

        CharController3.CharControlSag3 = false;
        CharController3.CharControlSol3 = false;
        CharController3.CharControlAsagi3 = false;
        CharController3.CharControlYukari3 = false;
    }
    void MevcutBolumunAyari()
    {
        if (BolumNumarasi > 10) {
             
            if (KarakterlerinHareketHakki == 0)
            {
                if (!BolumGecildi)
                {
                    Invoke("OyunBittiAta", 1.0f);
                }

                Invoke("KarakterHareketDevreDisi", 0.015f);
            }
            else
            {
                if (!BolumGecildi)
                {
                    CharController1.CharControlSag1 = true;
                    CharController1.CharControlSol1 = true;
                    CharController1.CharControlAsagi1 = true;
                    CharController1.CharControlYukari1 = true;

                    CharController2.CharControlSag2 = true;
                    CharController2.CharControlSol2 = true;
                    CharController2.CharControlAsagi2 = true;
                    CharController2.CharControlYukari2 = true;
                    if (BolumNumarasi > 25)
                    {
                        CharController3.CharControlSag3 = true;
                        CharController3.CharControlSol3 = true;
                        CharController3.CharControlAsagi3 = true;
                        CharController3.CharControlYukari3 = true;
                    }
                }
            }

            if (KarakterlerinHareketHakki == 0 && !BolumGecildi)
            {
                if (ToplarAsagi > 0)
                {
                    ToplarAsagi -= Time.deltaTime;
                }
                if (ToplarAsagi < 2.0f && ToplarAsagi > 0.2f)
                {
                    Char1Col.Character1.transform.position = Char1Col.Character1.transform.position + new Vector3(0, 0, 0.015f);
                    Char2Col.Character2.transform.position = Char2Col.Character2.transform.position + new Vector3(0, 0, 0.015f);
                    if (BolumNumarasi > 25)
                    {
                        Char3Col.Character3.transform.position = Char3Col.Character3.transform.position + new Vector3(0, 0, 0.015f);
                    }
                }
            }
            Count.text = KarakterlerinHareketHakki.ToString();
         }
        else
        {
            Count.text = "∞";
            if (!BolumGecildi)
            {
                CharController1.CharControlSag1 = true;
                CharController1.CharControlSol1 = true;
                CharController1.CharControlAsagi1 = true;
                CharController1.CharControlYukari1 = true;

                CharController2.CharControlSag2 = true;
                CharController2.CharControlSol2 = true;
                CharController2.CharControlAsagi2 = true;
                CharController2.CharControlYukari2 = true;
            }
        }
    }

    void OyunBittiAnaMenuTekrarYukle()
    {
        SceneManager.LoadScene("Bolum" + AnaMenu.Bolum.ToString());

        OyuncuAyar.Menu_isActive = 1;
        PlayerPrefs.SetInt("Menu_isActive", OyuncuAyar.Menu_isActive);
    }

    public static void MoveCountGenel()
    {
        if (GameObject.Find("Bolum/Karakter1/Ball_Barrier1_1").gameObject.activeInHierarchy && Char1Col.Yesil_Top_HareketSayisi_5 > 0)
        {
            Char1Col.Yesil_Top_HareketSayisi_5--;
        }
        if (GameObject.Find("Bolum/Karakter1/Ball_Barrier1_2").gameObject.activeInHierarchy && Char1Col.Yesil_Top_HareketSayisi_3 > 0)
        {
            Char1Col.Yesil_Top_HareketSayisi_3--;
        }

        if (GameObject.Find("Bolum/Karakter2/Ball_Barrier2_1").gameObject.activeInHierarchy && Char2Col.Sari_Top_HareketSayisi_5 > 0)
        {
            Char2Col.Sari_Top_HareketSayisi_5--;
        }
        if (GameObject.Find("Bolum/Karakter2/Ball_Barrier2_2").gameObject.activeInHierarchy && Char2Col.Sari_Top_HareketSayisi_3 > 0)
        {
            Char2Col.Sari_Top_HareketSayisi_3--;
        }
        if (AnaMenu.Bolum > 25) { 
        if (GameObject.Find("Bolum/Karakter3/Ball_Barrier3_1").gameObject.activeInHierarchy && Char3Col.Mavi_Top_HareketSayisi_5 > 0)
        {
            Char3Col.Mavi_Top_HareketSayisi_5--;
        }
        if (GameObject.Find("Bolum/Karakter3/Ball_Barrier3_2").gameObject.activeInHierarchy && Char3Col.Mavi_Top_HareketSayisi_3 > 0)
        {
            Char3Col.Mavi_Top_HareketSayisi_3--;
        }
        }

        KarakterlerinHareketHakki -= 1;
       
    }
    public static void MoveCountChar1()
    {
        if (GameObject.Find("Bolum/Karakter1/Ball_Barrier1_1").gameObject.activeInHierarchy && Char1Col.Yesil_Top_HareketSayisi_5 > 0)
        {
            Char1Col.Yesil_Top_HareketSayisi_5--;
        }
        if (GameObject.Find("Bolum/Karakter1/Ball_Barrier1_2").gameObject.activeInHierarchy && Char1Col.Yesil_Top_HareketSayisi_3 > 0)
        {
            Char1Col.Yesil_Top_HareketSayisi_3--;
        }

        if (GameObject.Find("Bolum/Karakter2/Ball_Barrier2_1").gameObject.activeInHierarchy && Char2Col.Sari_Top_HareketSayisi_5 > 0)
        {
            Char2Col.Sari_Top_HareketSayisi_5--;
        }
        if (GameObject.Find("Bolum/Karakter2/Ball_Barrier2_2").gameObject.activeInHierarchy && Char2Col.Sari_Top_HareketSayisi_3 > 0)
        {
            Char2Col.Sari_Top_HareketSayisi_3--;
        }

        if (AnaMenu.Bolum > 25)
        {
            if (GameObject.Find("Bolum/Karakter3/Ball_Barrier3_1").gameObject.activeInHierarchy && Char3Col.Mavi_Top_HareketSayisi_5 > 0)
            {
                Char3Col.Mavi_Top_HareketSayisi_5--;
            }
            if (GameObject.Find("Bolum/Karakter3/Ball_Barrier3_2").gameObject.activeInHierarchy && Char3Col.Mavi_Top_HareketSayisi_3 > 0)
            {
                Char3Col.Mavi_Top_HareketSayisi_3--;
            }
        }

        KarakterlerinHareketHakki -= 1;
    }
    void Update() {

        AnaMenu.Bolum = PlayerPrefs.GetInt("OyuncuHangiBolumdeKaldi");
        OyuncuAyar.BolumPlayCount = PlayerPrefs.GetInt("BolumuDahaOnceOynadi");
       StgNew.OyuncununGectigiBolumler = PlayerPrefs.GetInt("OyuncununGectigiBolumler");

        if (OyuncuAyar.Menu_isActive == 0)
        {
            transform.GetChild(6).gameObject.SetActive(false);
            transform.GetChild(5).gameObject.SetActive(true);


                if (GridKayma.mainTextureOffset.y > 0)
                {
                    Grid_y -= 0.01f;
                }
                GridKayma.mainTextureOffset = new Vector2(GridKayma.mainTextureOffset.x, Grid_y);


            if (!GecikmeliSwipe)
            {
                Invoke("GecikmeliSwipeEtkin", 0.75f);
                GecikmeliSwipe = true;
            }

        }
        else
        {
            if (GridKayma.mainTextureOffset.y < 1.0f)
            {
                Grid_y += 0.01f;
            }
            GridKayma.mainTextureOffset = new Vector2(GridKayma.mainTextureOffset.x, Grid_y);

            GecikmeliSwipe = false;

            if (BolumNumarasi <= 25)
            {
                CharController1.SwipeDisabled = true;
                CharController2.SwipeDisabled = true;
            }
            else
            {
                CharController1.SwipeDisabled = true;
                CharController2.SwipeDisabled = true;
                CharController3.SwipeDisabled = true;
            }

            transform.GetChild(6).gameObject.SetActive(true);
            transform.GetChild(5).gameObject.SetActive(false);

            if (BolumNumarasi == 1)
            {
                if (AnaMenu.Bolum1OzelSwipeIcoDevreDisi)
                {
                    transform.GetChild(7).gameObject.SetActive(false);
                }
                else
                {
                    transform.GetChild(7).gameObject.SetActive(true);
                }
            }

        }

        transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "STAGE " + BolumNumarasi.ToString();
        transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 14;

        transform.GetChild(5).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "STAGE " + BolumNumarasi.ToString();
        transform.GetChild(5).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().fontSize = Screen.width / 18;


        if (transform.GetChild(5).gameObject.activeInHierarchy)
        {
            CharController1.GameMenuAktifMi_1 = true;
            CharController2.GameMenuAktifMi_2 = true;
            CharController3.GameMenuAktifMi_3 = true;
        }
        else
        {
            CharController1.GameMenuAktifMi_1 = false;
            CharController2.GameMenuAktifMi_2 = false;
            CharController3.GameMenuAktifMi_3 = false;
        }

        if (MenuOyunIci.activeInHierarchy || BolumTamamlandiPanel.activeInHierarchy || OyunBittiPaneli.activeInHierarchy)
        {
            Canvas_BgMusic.DurdurmaMenuAcildi_BgMusicKes = true;
        }
        else
        {
            Canvas_BgMusic.DurdurmaMenuAcildi_BgMusicKes = false;
        }

        if (!MenuOyunIci.activeInHierarchy) {

            if (AnaMenu.MusicSes < 1)
            {

                Music.isOn = true;

            }
            else
            {
                if (AnaMenu.MusicSes == 1)
                {
                    Music.isOn = true;
                }
                else if (AnaMenu.MusicSes == 2)
                {
                    Music.isOn = false;
                }
            }


            if (AnaMenu.FxSes < 1)
            {
                SoundFX.isOn = true;
            }
            else
            {
                if (AnaMenu.FxSes == 1)
                {
                    SoundFX.isOn = true;
                }
                else if (AnaMenu.FxSes == 2)
                {
                    SoundFX.isOn = false;
                }
            }

            if (AnaMenu.Gosterge == 1)
            {
                Indicator.isOn = true;
            }
            else
            {
                Indicator.isOn = false;
            }
        }
        else
        {
            if (Music.isOn)
            {
                AnaMenu.MusicSes = 1;
                PlayerPrefs.SetInt("MusicOn", AnaMenu.MusicSes);
            }
            else
            {
                AnaMenu.MusicSes = 2;
                PlayerPrefs.SetInt("MusicOn", AnaMenu.MusicSes);
            }

            if (SoundFX.isOn)
            {
                AnaMenu.FxSes = 1;
                PlayerPrefs.SetInt("FxOn", AnaMenu.FxSes);
            }
            else
            {
                AnaMenu.FxSes = 2;
                PlayerPrefs.SetInt("FxOn", AnaMenu.FxSes);
            }

            if (Indicator.isOn)
            {
                AnaMenu.Gosterge = 1;
                PlayerPrefs.SetInt("IndicatorOn", AnaMenu.Gosterge);
            }
            else
            {
                AnaMenu.Gosterge = 0;
                PlayerPrefs.SetInt("IndicatorOn", AnaMenu.Gosterge);
            }
        }

        Money.text = OyuncuAyar.Para.ToString();

        if (OyuncuAyar.SinirsizCan != 1)
        {
            Health.text = OyuncuAyar.Can.ToString();
        }
        else
        {
            Health.text = "∞";
        }

        HardBallLockerTxt.fontSize = Screen.width / 28;
        BallLockerTxt.fontSize = Screen.width / 28;
        WallCreatorTxt.fontSize = Screen.width / 28;
        WallBreakerTxt.fontSize = Screen.width / 28;
        RemoverBallLockerTxt.fontSize = Screen.width / 28;

        HBL_5Txt.fontSize = Screen.width / 20;
        BL_3Txt.fontSize = Screen.width / 20;

        if (OyuncuAyar.SinirsizHardBallBlocker != 1)
        { 
            HBL_KullanimHakkiTxt.text = OyuncuAyar.HardBallLockerKullanim.ToString();
        }
        else
        {
            HBL_KullanimHakkiTxt.text = "∞";
        }

        if (OyuncuAyar.SinirsizBallBlocker != 1)
        {
            BL_KullanimHakkiTxt.text = OyuncuAyar.BallLockerKullanim.ToString();
        }
        else
        {
            BL_KullanimHakkiTxt.text = "∞";
        }

        if (OyuncuAyar.SinirsizWallCreator != 1)
        {
            WC_KullanimHakkiTxt.text = OyuncuAyar.WallCreatorKullanim.ToString();
        }
        else
        {
            WC_KullanimHakkiTxt.text = "∞";
        }

        if (OyuncuAyar.SinirsizWallBreaker != 1)
        {
            WB_KullanimHakkiTxt.text = OyuncuAyar.WallBreakerKullanim.ToString();
        }
        else
        {
            WB_KullanimHakkiTxt.text = "∞";
        }


        HBL_KullanimHakkiTxt.fontSize = Screen.width / 20;
        BL_KullanimHakkiTxt.fontSize = Screen.width / 20;
        WC_KullanimHakkiTxt.fontSize = Screen.width / 20;
        WB_KullanimHakkiTxt.fontSize = Screen.width / 20;

        Infinity1Txt.fontSize = Screen.width / 20;

        Count.fontSize = Screen.width / 16;
        Money.fontSize = Screen.width / 16;
        Health.fontSize = Screen.width / 16;

        PausedText.fontSize = Screen.width / 12;
        MusicText.fontSize = Screen.width / 14;
        SoundFXText.fontSize = Screen.width / 14;
        IndicatorText.fontSize = Screen.width / 14;

        TryAgain.text = "TRY AGAIN";
        TryAgain.fontSize = Screen.width / 12;

        MissionPassed.text = "STAGE " + BolumNumarasi + "\nCOMPLETED";
        MissionPassed.fontSize = Screen.width / 11;

        if (SwipeIcinAyarlarMenuAcildiKontrol)
        {
            CharController1.SwipeDisabledPauseMenu = true;
            CharController2.SwipeDisabledPauseMenu = true;
            CharController3.SwipeDisabledPauseMenu = true;
        }
        else
        {
            CharController1.SwipeDisabledPauseMenu = false;
            CharController2.SwipeDisabledPauseMenu = false;
            CharController3.SwipeDisabledPauseMenu = false;
        }
        
        if(BolumTamamlandiPanel.activeInHierarchy || OyunBittiPaneli.activeInHierarchy)
        {
            BolumTamamlanincaPauseMenuAcma = true;
        }
        else
        {
            BolumTamamlanincaPauseMenuAcma = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape) && !transform.GetChild(6).gameObject.activeInHierarchy)
        {
            if (!transform.GetChild(5).gameObject.transform.GetChild(3).gameObject.activeInHierarchy)
            { 
              OyunIciMenuTiklama();
            }

            if (BolumTamamlandiPanel.activeInHierarchy)
            {
                if (timer <= 0.2f)
                {
                    Invoke("DigerBolumAnaMenu", 0);
                }                
            }
            else if (OyunBittiPaneli.activeInHierarchy)
            {
                OyunBittiAnaMenuTekrarYukle();
            }
        }
        if (BolumTamamlandiPanel.activeInHierarchy)
        {
            timerStart = true;
        }
        else
        {
            timer = 2.7f;
        }

        if (timerStart)
        {
            if (timer > 0.0f)
            {
                timer -= Time.deltaTime;
            }
        }

        if (Zamanlayici < 1.5f) {

            Zamanlayici += Time.deltaTime;

        }
        if (Zamanlayici > 1.25f) {


            if (!BolumGecildi)
            {
                Karakterler_IsTrigger = false;
            }
            else
            {
                Invoke("ArkaPlan", 1.0f);
            }

            MevcutBolumunAyari();

        }
        else
        {
                OyunBaslangiciGecikme = false;

                Karakterler_IsTrigger = true;

                CharController1.CharControlSag1 = false;
                CharController1.CharControlSol1 = false;
                CharController1.CharControlAsagi1 = false;
                CharController1.CharControlYukari1 = false;

                CharController2.CharControlSag2 = false;
                CharController2.CharControlSol2 = false;
                CharController2.CharControlAsagi2 = false;
                CharController2.CharControlYukari2 = false;

            if (BolumNumarasi > 25) {
                CharController3.CharControlSag3 = false;
                CharController3.CharControlSol3 = false;
                CharController3.CharControlAsagi3 = false;
                CharController3.CharControlYukari3 = false;
            }
        }

        if (BolumNumarasi <= 25)
        {
            if (YesilKapi && SariKapi)
            {
                BolumGecildi = true;
            }
            else
            {
                BolumGecildi = false;
            }
        }
        else if (BolumNumarasi >= 26)
        {
            if (YesilKapi && SariKapi && MaviKapi)
            {
                BolumGecildi = true;
            }
            else
            {
                BolumGecildi = false;
            }
        }

        if (BolumGecildi)
        {
            if (!Tespit)
            {
                Invoke("BolumOK",0);
                Tespit = true;
            }
            KarakterHareketGostergeAktif = false;

            Invoke("GecikmeliYap", 0.5f);
           
            Invoke("BolumTamamlandiPaneli", 0.3f);

            Invoke("KarakterHareketDevreDisi", 0);

            Invoke("ArkaPlan", 1.0f);
        }

        if (AnaMenu.OyunMenu_OyunIciMenuKapatma)
        {
            Invoke("OyunIciMenuTiklama", 0.05f);
            AnaMenu.OyunMenu_OyunIciMenuKapatma = false;
        }

    }


    void BolumOK()
    {
        if (BolumNumarasi >= 10)
        {
            // Reklam.ReklamGosterimineBasla = 1;
            // PlayerPrefs.SetInt("ReklamGosterimineBasla", Reklam.ReklamGosterimineBasla);
        }

        Tamamlandi_MoveHakki = KarakterlerinHareketHakki;

        OyuncuAyar.BolumPlayCount++;
            PlayerPrefs.SetInt("BolumuDahaOnceOynadi", OyuncuAyar.BolumPlayCount);
    }

    void GecikmeliYap()
    {
        if (!KalanHareketiParayaAta)
        {
            Invoke("ParaAta", 0);
            KalanHareketiParayaAta = true;
        }
    }

    void ParaAta()
    {
        // ILK 10 BOLUM UNLIMITED MOVE DOLAYISIYLA PARA ARTISI OLMAZ!
        if (OyuncuAyar.BolumPlayCount == 2 && KarakterlerinHareketHakki > 0)
        {
            KarakterlerinHareketHakki--;
            OyuncuAyar.Para++;
            PlayerPrefs.SetInt("Para", OyuncuAyar.Para);
            Invoke("ParaAta2", 0.05f);
        }
    }
    void ParaAta2()
    {
        KalanHareketiParayaAta = false;
    }
    void BolumTamamlandiPaneli()
    {
        BolumTamamlandiPanel.SetActive(true);
    }

    void ArkaPlan()
    {
        Karakterler_IsTrigger = true;

        BgUstveAltAnim = true; 
    }

    void OyunBittiAta()
    {
        if (!BolumGecildi) {
            
            OyunBittiPaneli.SetActive(true);

            KarakterHareketGostergeAktif = false;

            if (!GameOver_HealtMinusOne)
            {
                Invoke("CanBirAzaliyor",0);
                GameOver_HealtMinusOne = true;
            }
            OyunBittiBG.SetActive(true);

        }
    }

    void CanBirAzaliyor()
    {
        if (OyuncuAyar.Can > 0 && OyuncuAyar.SinirsizCan != 1) { 
        OyuncuAyar.Can--;
        PlayerPrefs.SetInt("Can", OyuncuAyar.Can);
        }
    }

    public void DigerBolum() {

        if ((StgNew.OyuncununGectigiBolumler - 1)> AnaMenu.Bolum)
        {
            OyuncuAyar.BolumPlayCount = 2;
            PlayerPrefs.SetInt("BolumuDahaOnceOynadi", OyuncuAyar.BolumPlayCount);
        }
        else
        {
            OyuncuAyar.BolumPlayCount = 1;
            PlayerPrefs.SetInt("BolumuDahaOnceOynadi", OyuncuAyar.BolumPlayCount);
        }

        // Reklam.GecisReklami();

        DevamEt.Play("YeniBolum", -1, 0f);
        Invoke("BolumuYukle", 0.9f);
    }
    void BolumuYukle()
    {
        AnaMenu.Bolum += 1;
        PlayerPrefs.SetInt("OyuncuHangiBolumdeKaldi", AnaMenu.Bolum);

        if (BolumNumarasi != 150)
        {
        OyuncuAyar.Menu_isActive = 0;
        PlayerPrefs.SetInt("Menu_isActive",OyuncuAyar.Menu_isActive);        
        }
        else
        {
            OyuncuAyar.Menu_isActive = 1;
            PlayerPrefs.SetInt("Menu_isActive", OyuncuAyar.Menu_isActive);
        }

        SceneManager.LoadScene(BolumYukle);
    }
    public void DigerBolumAnaMenu()
    {
        OyuncuAyar.BolumPlayCount = 1;
        PlayerPrefs.SetInt("BolumuDahaOnceOynadi", OyuncuAyar.BolumPlayCount);

        DevamEt.Play("YeniBolum", -1, 0f);
        Invoke("BolumuYukleAnaMenu", 1.0f);

        // Reklam.GecisReklami();

    }
    void BolumuYukleAnaMenu()
    {
        AnaMenu.Bolum += 1;
        PlayerPrefs.SetInt("OyuncuHangiBolumdeKaldi", AnaMenu.Bolum);

        SceneManager.LoadScene(BolumYukle);

        OyuncuAyar.Menu_isActive = 1;
        PlayerPrefs.SetInt("Menu_isActive", OyuncuAyar.Menu_isActive);
    }

    public void TekrarOyna() {

        if (OyuncuAyar.Can > 0 || OyuncuAyar.SinirsizCan == 1) {
        
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }

        // Reklam.GecisReklami();

    }
    public void TekrarOynaBolumTamamlandi()
    {
        if (OyuncuAyar.Can >= 0) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        // Reklam.GecisReklami();

    }
    public void OyunIciMenuTiklama()    
    {
        if (!BolumTamamlanincaPauseMenuAcma)
        {
            if (!ButonDisable)
            {
                OyunIciMenuIcon.Play("OyunIciSettings", -1, 0);

                if (MenuOyunIci.activeInHierarchy)
                {
                    OyunIciMenusu.Play("OyunIciMenusuDonus", -1, 0f);
                    OyunIciMenuBG.Play("OyunIciMenuBGGidis", -1, 0f);
                    Invoke("YokEt", 0.7f);
                }
                else
                {
                    MenuOyunIci.SetActive(true);
                    MenuOyunIciPanelBG.SetActive(true);
                    SwipeIcinAyarlarMenuAcildiKontrol = true; // Çünkü PAUSE menü açıldı

                    OyunIciMenusu.Play("OyunIciMenusu", -1, 0.1f);
                    OyunIciMenuBG.Play("OyunIciMenuBG", -1, 0.1f);
                }

                Invoke("BtnDisableFalse", 0.85f);
                ButonDisable = true;
            }
        }
    }
    void BtnDisableFalse()
    {
        ButonDisable = false;
    }
    public void Devam()
    {
        OyunIciMenuIcon.Play("OyunIciSettings", -1, 0);
        OyunIciMenusu.Play("OyunIciMenusuDonus", -1, 0f);
        OyunIciMenuBG.Play("OyunIciMenuBGGidis", -1, 0f);

        Invoke("YokEt", 0.7f);
    }
    void YokEt()
    {
        MenuOyunIci.SetActive(false);
        MenuOyunIciPanelBG.SetActive(false);
        SwipeIcinAyarlarMenuAcildiKontrol = false; // Çünkü PAUSE menü kapandı
    }
}