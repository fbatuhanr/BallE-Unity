using UnityEngine;
using System.Collections;
using UnityEngine.UI;
// BATUHAN OZTURK 12.02.17

    // 12.02.17 14.38 Updated
public class OyuncuAyar : MonoBehaviour
{
    GameObject BolumBariyerleri;

    Transform Gunes_IsikKaynagi;

    int BolumBariyerleri_count;

    public Color Standart_Border, Grey, Red, Orange, Yellow, Green, Aqua, Blue, Purple, Pink, White;

    public Material Barrier, Grid, Border_Backgrounds;

    public Sprite Blue_Dotted, Red_Dotted, Yellow_Dotted, Orange_Dotted, Green_Dotted;

    public Sprite BagMenu_Close_Img, BagMenu_Open_Img;

    public static int Menu_isActive;

    public static int Para;
    public static int Can;

    public static int HardBallLockerKullanim;
    public static int BallLockerKullanim;
    public static int WallCreatorKullanim;
    public static int WallBreakerKullanim;

    public static int SinirsizCan, SinirsizHardBallBlocker, SinirsizBallBlocker, SinirsizWallCreator, SinirsizWallBreaker;

    public static int MoreHealth;

    public static int ReklamKalkti;

    public static int BolumPlayCount;

    public static int MagazaDoubleWatch;

    bool ButonDisable;

    public static bool YesilTopBariyerleriAktifMi, SariTopBariyerleriAktifMi, MaviTopBariyerleriAktifMi;

    public static bool BagAcik;

    int Sayac_MultipleSingle;

    public static bool Multiple;

    void Start()
    {
        Gunes_IsikKaynagi = GameObject.Find("Light").transform;

        int RandomizeGunesRotasyon = Random.Range(0, 4);

        if (RandomizeGunesRotasyon == 0)
        {
            Gunes_IsikKaynagi.rotation = Quaternion.Euler(new Vector3(30, 25, 0));
        }
        else if (RandomizeGunesRotasyon == 1)
        {
            Gunes_IsikKaynagi.rotation = Quaternion.Euler(new Vector3(30, -25, 0));
        }
        else if (RandomizeGunesRotasyon == 2)
        {
            Gunes_IsikKaynagi.rotation = Quaternion.Euler(new Vector3(-25, 20, 0));
        }
        else if (RandomizeGunesRotasyon == 3)
        {
            Gunes_IsikKaynagi.rotation = Quaternion.Euler(new Vector3(-25, -20, 0));
        }

        GameObject.Find("Camera").gameObject.GetComponent<Camera>().farClipPlane = 15;  

        Magaza_Bariyer.Mevcut_BarrierColors = PlayerPrefs.GetInt("Mevcut_BariyerRengi");
        Magaza_Bg_Grid.Mevcut_GridColors = PlayerPrefs.GetInt("Mevcut_IzgaraRengi");
        Magaza_Bg_Grid.Mevcut_BackgroundColors = PlayerPrefs.GetInt("Mevcut_BackgroundRengi");
        Magaza_Bg_Grid.Mevcut_BorderColors = PlayerPrefs.GetInt("Mevcut_BorderRengi");

        switch (Magaza_Bariyer.Mevcut_BarrierColors)
        {
            case 0:
                Barrier.color = Red;
                break;
            case 1:
                Barrier.color = Orange;
                break;
            case 2:
                Barrier.color = Yellow;
                break;
            case 3:
                Barrier.color = Green;
                break;
            case 4:
                Barrier.color = Aqua;
                break;
            case 5:
                Barrier.color = Blue;
                break;
            case 6:
                Barrier.color = Purple;
                break;
            case 7:
                Barrier.color = Pink;
                break;
            case 8:
                Barrier.color = White;
                break;
            default:
                Barrier.color = Red;
                break;
        }
        switch (Magaza_Bg_Grid.Mevcut_GridColors)
        {
            case 0:
                Grid.color = Grey;
                break;
            case 1:
                Grid.color = Orange;
                break;
            case 2:
                Grid.color = Yellow;
                break;
            case 3:
                Grid.color = Green;
                break;
            case 4:
                Grid.color = Aqua;
                break;
            case 5:
                Grid.color = Blue;
                break;
            case 6:
                Grid.color = Purple;
                break;
            case 7:
                Grid.color = Pink;
                break;
            case 8:
                Grid.color = White;
                break;
            default:
                Grid.color = Grey;
                break;
        }
        switch (Magaza_Bg_Grid.Mevcut_BorderColors)
        {
            case 0:
                Border_Backgrounds.color = Standart_Border;
                break;
            case 1:
                Border_Backgrounds.color = Green;
                break;
            case 2:
                Border_Backgrounds.color = Orange;
                break;
            case 3:
                Border_Backgrounds.color = Red;
                break;
            case 4:
                Border_Backgrounds.color = Yellow;
                break;
        }
        switch (Magaza_Bg_Grid.Mevcut_BackgroundColors)
        {
            case 0:
                BolumBackgrounds.Background_ColorCode = 0;
                break;
            case 1:
                BolumBackgrounds.Background_ColorCode = 1;
                break;
            case 2:
                BolumBackgrounds.Background_ColorCode = 2;
                break;
            case 3:
                BolumBackgrounds.Background_ColorCode = 3;
                break;
            case 4:
                BolumBackgrounds.Background_ColorCode = 4;
                break;
        }


        Multiple = false;
        BagAcik = false;

        Sayac_MultipleSingle = 1;

        YesilTopBariyerleriAktifMi = false;
        SariTopBariyerleriAktifMi = false;
        MaviTopBariyerleriAktifMi = false;

        ButonDisable = false;

        transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.SetActive(false);
        transform.GetChild(5).gameObject.transform.GetChild(3).gameObject.SetActive(false);

        transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(3).gameObject.SetActive(false);
        transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(4).gameObject.SetActive(false);

        transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.SetActive(false);

        Invoke("InvokerStagesReturn", 0.5f);

        BolumBariyerleri = GameObject.Find("Bolum/Bolum_Barriers");

        Invoke("BariyerColliderAyar", 0.1f);
    }

    void InvokerStagesReturn()
    {
        StgNew.StagesdenGelis = false;
    }
    void BariyerColliderAyar()
    {
      if (AnaMenu.Bolum != 151)
        {
        BolumBariyerleri_count = BolumBariyerleri.transform.childCount;

         for (int i = 1; i< BolumBariyerleri_count; i++) {

            if (BolumBariyerleri.transform.GetChild(i).gameObject.GetComponent<BoxCollider>() != null) { 

            BolumBariyerleri.transform.GetChild(i).gameObject.GetComponent<BoxCollider>().size = new Vector3(0.1f, 0.025f, 8);

            BolumBariyerleri.transform.GetChild(i).gameObject.transform.GetChild(0).GetComponent<BoxCollider>().size = new Vector3(BolumBariyerleri.transform.GetChild(i).gameObject.transform.GetChild(0).GetComponent<BoxCollider>().size.x, BolumBariyerleri.transform.GetChild(i).gameObject.transform.GetChild(0).GetComponent<BoxCollider>().size.y, 0.55f);
            BolumBariyerleri.transform.GetChild(i).gameObject.transform.GetChild(1).GetComponent<BoxCollider>().size = new Vector3(BolumBariyerleri.transform.GetChild(i).gameObject.transform.GetChild(1).GetComponent<BoxCollider>().size.x, BolumBariyerleri.transform.GetChild(i).gameObject.transform.GetChild(1).GetComponent<BoxCollider>().size.y, 0.55f);

            }
            else
            {
                BolumBariyerleri.transform.GetChild(i).gameObject.AddComponent<BoxCollider>();

                BolumBariyerleri.transform.GetChild(i).gameObject.GetComponent<BoxCollider>().isTrigger = true;
                BolumBariyerleri.transform.GetChild(i).gameObject.GetComponent<BoxCollider>().center = new Vector3(0, 0, -3.5f);
                BolumBariyerleri.transform.GetChild(i).gameObject.GetComponent<BoxCollider>().size = new Vector3(0.1f, 0.025f, 8);

                BolumBariyerleri.transform.GetChild(i).gameObject.transform.GetChild(0).GetComponent<BoxCollider>().size = new Vector3(BolumBariyerleri.transform.GetChild(i).gameObject.transform.GetChild(0).GetComponent<BoxCollider>().size.x, BolumBariyerleri.transform.GetChild(i).gameObject.transform.GetChild(0).GetComponent<BoxCollider>().size.y, 0.55f);
                BolumBariyerleri.transform.GetChild(i).gameObject.transform.GetChild(1).GetComponent<BoxCollider>().size = new Vector3(BolumBariyerleri.transform.GetChild(i).gameObject.transform.GetChild(1).GetComponent<BoxCollider>().size.x, BolumBariyerleri.transform.GetChild(i).gameObject.transform.GetChild(1).GetComponent<BoxCollider>().size.y, 0.55f);
            }
            }
        }
    }

    void Update()
    {
        if (AnaMenu.Bolum == 151)
        {
            Menu_isActive = 1;
            PlayerPrefs.SetInt("Menu_isActive", Menu_isActive);
        }

        Menu_isActive = PlayerPrefs.GetInt("Menu_isActive");
            
        HardBallLockerKullanim = PlayerPrefs.GetInt("HardBallLockerKullanimHakki");
        
        BallLockerKullanim = PlayerPrefs.GetInt("BallLockerKullanimHakki");

        WallCreatorKullanim = PlayerPrefs.GetInt("WallCreatorKullanimHakki");
        WallBreakerKullanim = PlayerPrefs.GetInt("WallBreakerKullanimHakki");

        SinirsizCan = PlayerPrefs.GetInt("SinirsizCan");

        SinirsizHardBallBlocker = PlayerPrefs.GetInt("SinirsizHardBallLocker");

        SinirsizBallBlocker = PlayerPrefs.GetInt("SinirsizBallLocker");

        SinirsizWallCreator = PlayerPrefs.GetInt("SinirsizWallCreator");

        SinirsizWallBreaker = PlayerPrefs.GetInt("SinirsizWallBreaker");

        if (CharTouchClick.SecimIcinTopHareketEttimi || BarrierTouchClick.SecimIcinHareketEdildiMi)
        {
            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.SetActive(false);
        }

        if (transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.activeInHierarchy)
        {
            transform.GetChild(5).gameObject.transform.GetChild(7).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(5).gameObject.transform.GetChild(7).gameObject.SetActive(false);
        }


        // for hard ball blocker
        if ((SinirsizHardBallBlocker == 1 || HardBallLockerKullanim > 0) && (!YesilTopBariyerleriAktifMi || !SariTopBariyerleriAktifMi || !MaviTopBariyerleriAktifMi))
        {
            transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Button>().interactable = true;
        }
        else
        {
            transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Button>().interactable = false;
        }

        // for standart ball blocker
        if ((SinirsizBallBlocker == 1 || BallLockerKullanim > 0) && (!YesilTopBariyerleriAktifMi || !SariTopBariyerleriAktifMi || !MaviTopBariyerleriAktifMi))
        {
            transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Button>().interactable = true;
        }
        else
        {
            transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Button>().interactable = false;
        }

        //for block remover
        if (YesilTopBariyerleriAktifMi || SariTopBariyerleriAktifMi || MaviTopBariyerleriAktifMi)
        {
            transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.GetComponent<Button>().interactable = true;
        }
        else
        {
            transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.GetComponent<Button>().interactable = false;
        }

        //for wall creat
        if ((SinirsizWallCreator == 1 || WallCreatorKullanim > 0))
        {
            transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<Button>().interactable = true;
        }
        else
        {
            transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<Button>().interactable = false;
        }

        //for wall remover
        if ((SinirsizWallBreaker == 1 || WallBreakerKullanim > 0))
        {
            transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<Button>().interactable = true;
        }
        else
        {
            transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<Button>().interactable = false;
        }


        if (transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.activeInHierarchy)
        {
            BagAcik = true;
        }
        else
        {
            BagAcik = false;
        }


        if (Input.GetKeyDown(KeyCode.Escape) && !transform.GetChild(6).gameObject.activeInHierarchy)
        {
            if (transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.activeInHierarchy)
            {
                Bag_MenuOpenClose();
            }
        }

        if (transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.activeInHierarchy)
        {
            transform.GetChild(5).gameObject.transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.GetComponent<Button>().enabled = false;
            transform.GetChild(5).gameObject.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.GetComponent<Button>().enabled = false;
            transform.GetChild(5).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.GetComponent<Button>().enabled = false;
        }
        else
        {
            transform.GetChild(5).gameObject.transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.GetComponent<Button>().enabled = true;
            transform.GetChild(5).gameObject.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.GetComponent<Button>().enabled = true;
            transform.GetChild(5).gameObject.transform.GetChild(2).gameObject.transform.GetChild(3).gameObject.GetComponent<Button>().enabled = true;
        }

     if (transform.GetChild(0).gameObject.activeInHierarchy || transform.GetChild(2).gameObject.activeInHierarchy || transform.GetChild(4).gameObject.activeInHierarchy || transform.GetChild(6).gameObject.activeInHierarchy)
        {
            if (transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.activeInHierarchy)
            {
                Bag_MenuOpenClose();
                transform.GetChild(5).gameObject.transform.GetChild(5).gameObject.GetComponent<Button>().interactable = false;

                CharTouchClick.HardBallLockerActive = false;
                CharTouchClick.BallLockerActive = false;
                CharTouchClick.BallLockRemoverActive = false;

                BarrierTouchClick.WallCreator = false;
                BarrierTouchClick.WallBreaker = false;
            }
            else
            {
                transform.GetChild(5).gameObject.transform.GetChild(5).gameObject.GetComponent<Button>().interactable = false;
            }
        }
     else
        {
            transform.GetChild(5).gameObject.transform.GetChild(5).gameObject.GetComponent<Button>().interactable = true;
        }

        transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 26;

        transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 36;
        transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 36;
        transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 36;

        transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().fontSize = Screen.width / 20;

        if (CharTouchClick.HardBallLockerActive)
        {
            if (OyuncuAyar.SinirsizHardBallBlocker != 1)
            { 

            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = ": " + HardBallLockerKullanim.ToString();

            }
            else
            {
                transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = ": ∞";
            }

            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.SetActive(true);

            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(0).gameObject.SetActive(true);

            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.SetActive(false);
            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(3).gameObject.SetActive(false);
            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(4).gameObject.SetActive(false);
        }
        else if (CharTouchClick.BallLockerActive)
        {
            if (OyuncuAyar.SinirsizBallBlocker != 1)
            {
                transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = ": " + BallLockerKullanim.ToString();
            }
            else
            {
                transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = ": ∞";
            }
            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.SetActive(true);

            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(1).gameObject.SetActive(true);

            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.SetActive(false);
            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(3).gameObject.SetActive(false);
            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(4).gameObject.SetActive(false);
        }
        else if (CharTouchClick.BallLockRemoverActive)
        {
            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = ": ∞";

            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.SetActive(true);

            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.SetActive(true);

            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(3).gameObject.SetActive(false);
            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(4).gameObject.SetActive(false);
        }
        else if (BarrierTouchClick.WallCreator)
        {
            if (OyuncuAyar.SinirsizWallCreator != 1)
            {
                transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = ": " + WallCreatorKullanim.ToString();
            }
            else
            {
                transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = ": ∞";
            }

            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.SetActive(true);

            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(3).gameObject.SetActive(true);

            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.SetActive(false);
            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(4).gameObject.SetActive(false);
        }
        else if (BarrierTouchClick.WallBreaker)
        {
            if (OyuncuAyar.SinirsizWallBreaker != 1)
            {
                transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = ": " + WallBreakerKullanim.ToString();
            }
            else
            {
                transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().text = ": ∞";
            }

            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.SetActive(true);

            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(4).gameObject.SetActive(true);

            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.SetActive(false);
            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.transform.GetChild(3).gameObject.SetActive(false);
        }
        else
        {
            transform.GetChild(5).gameObject.transform.GetChild(6).gameObject.SetActive(false);
        }

    }


    public void HardBallLock()
    {
        if (!ButonDisable)
        {
            CharTouchClick.HardBallLockerActive = true;

            CharTouchClick.BallLockerActive = false;
            CharTouchClick.BallLockRemoverActive = false;

            BarrierTouchClick.WallCreator = false;
            BarrierTouchClick.WallBreaker = false;
        }

    }
    public void BallLock()
    {
        if (!ButonDisable)
        {
            CharTouchClick.BallLockerActive = true;

            CharTouchClick.HardBallLockerActive = false;
            CharTouchClick.BallLockRemoverActive = false;

            BarrierTouchClick.WallCreator = false;
            BarrierTouchClick.WallBreaker = false;
        }
    }
    public void WallCreat()
    {
        if (!ButonDisable)
        {
            BarrierTouchClick.Bariyer_Secenek = 1;

            BarrierTouchClick.WallCreator = true;

            BarrierTouchClick.WallBreaker = false;

            CharTouchClick.BallLockRemoverActive = false;
            CharTouchClick.HardBallLockerActive = false;
            CharTouchClick.BallLockerActive = false;
        }
    }
    public void WallBreak()
    {
        if (!ButonDisable)
        {
            if (!BarrierTouchClick.DahaOnceSecildiMi)
            {
                WallCreat();
                Invoke("WallBreak_Delay", 0.02f);
            }
            else
            {
                BarrierTouchClick.Bariyer_Secenek = 2;
                BarrierTouchClick.WallBreaker = true;
                BarrierTouchClick.WallCreator = false;

                CharTouchClick.BallLockRemoverActive = false;
                CharTouchClick.HardBallLockerActive = false;
                CharTouchClick.BallLockerActive = false;
            }
        }
    }
    void WallBreak_Delay()
    {
        BarrierTouchClick.Bariyer_Secenek = 2;

        BarrierTouchClick.WallBreaker = true;

        BarrierTouchClick.WallCreator = false;

        CharTouchClick.BallLockRemoverActive = false;
        CharTouchClick.HardBallLockerActive = false;
        CharTouchClick.BallLockerActive = false;
    }

    public void RemoverBallLock()
    {
        if (!ButonDisable)
        {
            CharTouchClick.BallLockRemoverActive = true;

            CharTouchClick.HardBallLockerActive = false;
            CharTouchClick.BallLockerActive = false;

            BarrierTouchClick.WallCreator = false;
            BarrierTouchClick.WallBreaker = false;
        }
    }

    public void Bag_MenuOpenClose()
    {
        if (!ButonDisable)
        {
            if (transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.activeInHierarchy)
            {
                transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.GetComponent<Animator>().Play("BackpackGeriDonus", -1, 0f);

                transform.GetChild(5).gameObject.transform.GetChild(3).gameObject.GetComponent<Animator>().speed = 1.5f;
                transform.GetChild(5).gameObject.transform.GetChild(3).gameObject.GetComponent<Animator>().Play("OyunIciMenuBGGidis", -1, 0f);

                Invoke("BagMenu_SetActiveFalse", 0.51f);
                transform.GetChild(5).gameObject.transform.GetChild(5).gameObject.GetComponent<Image>().sprite = BagMenu_Close_Img;
            }
            else
            {
                transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.SetActive(true);
                transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.GetComponent<Animator>().Play("Backpack", -1, 0.1f);

                transform.GetChild(5).gameObject.transform.GetChild(3).gameObject.SetActive(true);
                transform.GetChild(5).gameObject.transform.GetChild(3).gameObject.GetComponent<Animator>().speed = 1.0f;
                transform.GetChild(5).gameObject.transform.GetChild(3).gameObject.GetComponent<Animator>().Play("OyunIciMenuBG", -1, 0.1f);

                transform.GetChild(5).gameObject.transform.GetChild(5).gameObject.GetComponent<Image>().sprite = BagMenu_Open_Img;
            }

            Invoke("BtnDisableFalse", 0.6f);
            ButonDisable = true;
        }

    }

    public void Bag_MenuAcikKaldiysa()
    {
        if (!ButonDisable)
        {
            if (transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.activeInHierarchy)
            {
                transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.GetComponent<Animator>().Play("BackpackGeriDonus", -1, 0f);
                Invoke("BagMenu_SetActiveFalse", 0.51f);
                transform.GetChild(5).gameObject.transform.GetChild(5).gameObject.GetComponent<Image>().sprite = BagMenu_Close_Img;
            }

            Invoke("BtnDisableFalse", 0.6f);
            ButonDisable = true;
        }

    }

    void BtnDisableFalse()
    {
        ButonDisable = false;
    }

    void BagMenu_SetActiveFalse()
    {
        transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.SetActive(false);
        transform.GetChild(5).gameObject.transform.GetChild(3).gameObject.SetActive(false);
    }

    public void Single_Multiple()
    {
        if (Sayac_MultipleSingle == 1)
        {
            transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.GetComponent<Animator>().Play("Multiple_Open", -1, 0f);
            Multiple = true;
            transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Multiple";
            Sayac_MultipleSingle = 2;
        }
        else if (Sayac_MultipleSingle == 2)
        {
            transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.GetComponent<Animator>().Play("Multiple_Close", -1, 0f);
            Multiple = false;
            transform.GetChild(5).gameObject.transform.GetChild(4).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Single";
            Sayac_MultipleSingle = 1;
        }

    }

    public void SecimleriIptalEt()
    {
        CharTouchClick.HardBallLockerActive = false;
        CharTouchClick.BallLockerActive = false;
        CharTouchClick.BallLockRemoverActive = false;

        BarrierTouchClick.WallCreator = false;
        BarrierTouchClick.WallBreaker = false;
    }
}
