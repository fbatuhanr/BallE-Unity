using UnityEngine;
using System.Collections;
// BATUHAN OZTURK 26.12.16
public class Char1Col : MonoBehaviour {

    // OYUN MENÜSÜNDEN ULAŞMAK İÇİN TOPLAR ÜZERİNDE BULUNAN KARAKTER 1.COLLİDER ERİŞİMİNİ SAĞLAMAK AMACIYLA OLUŞTURULAN SCRIPT
    // HATIRLATMA CHAR 1 YESIL TOP

    bool ArrowSlide, BallsHide;

    public Animator YukariAnim, AsagiAnim, SagAnim, SolAnim;

    public GameObject Yukari, Asagi, Sag, Sol;

        public static Transform Character1;
        Collider Karakter1;

    float timer;

    public static int Yesil_Top_HareketSayisi_5, Yesil_Top_HareketSayisi_3;

    public static bool Top_BlockHakkiBitti_1, Top_BlockHakkiBitti_2;

    public static bool YesilTop;

    void Start()
    {

        YesilTop = false;

        Top_BlockHakkiBitti_1 = false;
        Top_BlockHakkiBitti_2 = false;

        Yesil_Top_HareketSayisi_5 = 10;
        Yesil_Top_HareketSayisi_3 = 5;


        Character1 = GetComponent<Transform>();
        Karakter1 = GetComponent<Collider>();

        timer = 1.25f;

        Karakter1.isTrigger = true;

        ArrowSlide = false;
        BallsHide = true;
    }
    void Yesil_Locker_AnimFalse_1()
    {
        transform.GetChild(0).gameObject.GetComponent<Animator>().Play("BirinciCubukGeriDonus", -1, 0f);
    }
    void Yesil_Locker_GameObjectFalse_1()
    {
        transform.GetChild(0).gameObject.SetActive(false);

        Top_BlockHakkiBitti_1 = false;

        CharController1.YesilTopEngeli_Kalkiyor = false;

        Yesil_Top_HareketSayisi_5 = 10;
    }
    void Yesil_Locker_AnimFalse_2()
    {
        transform.GetChild(1).gameObject.GetComponent<Animator>().Play("BirinciCubukGeriDonus", -1, 0f);
    }
    void Yesil_Locker_GameObjectFalse_2()
    {
        transform.GetChild(1).gameObject.SetActive(false);

        Top_BlockHakkiBitti_1 = false;

        CharController1.YesilTopEngeli_Kalkiyor = false;

        Yesil_Top_HareketSayisi_3 = 5;
    }


    void Karakter1_HareketEngellemesi_Coz()
    {
        CharController1.YukariGidisEngeli1 = false;
        CharController1.AsagiGidisEngeli1 = false;
        CharController1.SolaGidisEngeli1 = false;
        CharController1.SagaGidisEngeli1 = false;
    }

    void OnMouseDown()
    {
        if (CharTouchClick.BallLockRemoverActive && (transform.GetChild(0).gameObject.activeInHierarchy || transform.GetChild(1).gameObject.activeInHierarchy)) {

            YesilTop = true;
            Char2Col.SariTop = false;
            Char3Col.MaviTop = false;
        }
     }

    void Update()
    {
        if (transform.GetChild(0).gameObject.activeInHierarchy || transform.GetChild(1).gameObject.activeInHierarchy)
        {
            OyuncuAyar.YesilTopBariyerleriAktifMi = true;
        }
        else
        {
            OyuncuAyar.YesilTopBariyerleriAktifMi = false;
        }

        if (transform.GetChild(0).gameObject.activeInHierarchy)
        {
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMesh>().text = Yesil_Top_HareketSayisi_5.ToString(); ;
        }
        if (transform.GetChild(1).gameObject.activeInHierarchy)
        {
            transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMesh>().text = Yesil_Top_HareketSayisi_3.ToString(); ;
        }

        if (Yesil_Top_HareketSayisi_5 == 0 && !Top_BlockHakkiBitti_1)
        {
            CharController1.YesilTopEngeli_Kalkiyor = true;
            
            Invoke("Yesil_Locker_AnimFalse_1",0.1f);
            Invoke("Yesil_Locker_GameObjectFalse_1",1.25f);
            Invoke("Karakter1_HareketEngellemesi_Coz", 0.1f);

            Top_BlockHakkiBitti_1 = true;
        }
        if (Yesil_Top_HareketSayisi_3 == 0 && !Top_BlockHakkiBitti_2)
        {
            CharController1.YesilTopEngeli_Kalkiyor = true;

            Invoke("Yesil_Locker_AnimFalse_2", 0.1f);
            Invoke("Yesil_Locker_GameObjectFalse_2", 1.25f);
            Invoke("Karakter1_HareketEngellemesi_Coz", 0.1f);

            Top_BlockHakkiBitti_2 = true;
        }


        if (OyunMenu.Karakterler_IsTrigger) { 

        Karakter1.isTrigger = true;

        }
        else
        {
            Karakter1.isTrigger = false;
        }

        if ((Input.GetMouseButton(0) || AnaMenu.Gosterge == 1) && OyunMenu.MenuAcildimi != 1 && OyunMenu.KarakterHareketGostergeAktif) {

            ArrowSlide = true;
            BallsHide = false;
            // 1.3 saniye sonra görünmeye başlar
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            if (timer <= 0.3f)
            {
                if (!CharController1.YukariGidisEngeli1 && CharController1.CharControlYukari1)
                {
                    Yukari.SetActive(true);
                }
                else
                {
                    Yukari.SetActive(false);
                }

                if (!CharController1.AsagiGidisEngeli1 && CharController1.CharControlAsagi1)
                {
                    Asagi.SetActive(true);
                }
                else
                {
                    Asagi.SetActive(false);
                }

                if (!CharController1.SagaGidisEngeli1 && CharController1.CharControlSag1)
                {
                    Sag.SetActive(true);
                }
                else
                {
                    Sag.SetActive(false);
                }

                if (!CharController1.SolaGidisEngeli1 && CharController1.CharControlSol1)
                {
                    Sol.SetActive(true);
                }
                else
                {
                    Sol.SetActive(false);
                }
            }
                
        }
        else
        {
            timer = 1.5f;

            if (ArrowSlide)
            {
                Invoke("ArrowSlideKapanis", 0);
                ArrowSlide = false;
            }
            if (!BallsHide)
            {
                Invoke("ArrowsDisabled", 1.0f);
                BallsHide = true;
            }
        }
    }
    void ArrowSlideKapanis()
    {
        YukariAnim.Play("BallsColorSlide", -1, 0f);
        AsagiAnim.Play("BallsColorSlide", -1, 0f);
        SagAnim.Play("BallsColorSlide", -1, 0f);
        SolAnim.Play("BallsColorSlide", -1, 0f);
    }

    void ArrowsDisabled()
    {
        Yukari.SetActive(false);
        Asagi.SetActive(false);
        Sag.SetActive(false);
        Sol.SetActive(false);
    }
}
