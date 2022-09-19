using UnityEngine;
using System.Collections;
// BATUHAN OZTURK 08.01.17
public class Char3Col : MonoBehaviour
{
    // OYUN MENÜSÜNDEN ULAŞMAK İÇİN TOPLAR ÜZERİNDE BULUNAN KARAKTER 4.COLLİDER ERİŞİMİNİ SAĞLAMAK AMACIYLA OLUŞTURULAN SCRIPT
    // HATIRLATMA CHAR 3 MAVI TOP

    bool ArrowSlide, BallsHide;

    public Animator YukariAnim, AsagiAnim, SagAnim, SolAnim;

    public GameObject Yukari, Asagi, Sag, Sol;

    public static Transform Character3;
    Collider Karakter3;

    float timer;

    public static int Mavi_Top_HareketSayisi_5, Mavi_Top_HareketSayisi_3;

    public static bool Top_BlockHakkiBitti_1, Top_BlockHakkiBitti_2;

    public static bool MaviTop;

   void Start() {

        MaviTop = false;

        Top_BlockHakkiBitti_1 = false;
        Top_BlockHakkiBitti_2 = false;

        Mavi_Top_HareketSayisi_5 = 10;
            Mavi_Top_HareketSayisi_3 = 5;

        Character3 = GetComponent<Transform>();
        Karakter3 = GetComponent<Collider>();

        timer = 1.25f;

        Karakter3.isTrigger = true;

        ArrowSlide = false;
        BallsHide = true;
    }
    void Mavi_Locker_AnimFalse_1()
    {
        transform.GetChild(0).gameObject.GetComponent<Animator>().Play("BirinciCubukGeriDonus", -1, 0f);
    }
    void Mavi_Locker_GameObjectFalse_1()
    {
        transform.GetChild(0).gameObject.SetActive(false);

        Top_BlockHakkiBitti_1 = false;

        CharController3.MaviTopEngeli_Kalkiyor = false;

        Mavi_Top_HareketSayisi_5 = 10;
    }
    void Mavi_Locker_AnimFalse_2()
    {
        transform.GetChild(1).gameObject.GetComponent<Animator>().Play("BirinciCubukGeriDonus", -1, 0f);
    }
    void Mavi_Locker_GameObjectFalse_2()
    {
        transform.GetChild(1).gameObject.SetActive(false);

        Top_BlockHakkiBitti_2 = false;

        CharController3.MaviTopEngeli_Kalkiyor = false;

        Mavi_Top_HareketSayisi_3 = 5;
    }

    void Karakter3_HareketEngellemesi_Coz()
    {
        CharController3.YukariGidisEngeli3 = false;
        CharController3.AsagiGidisEngeli3 = false;
        CharController3.SolaGidisEngeli3 = false;
        CharController3.SagaGidisEngeli3 = false;
    }
    void OnMouseDown()
    {
        if (CharTouchClick.BallLockRemoverActive && (transform.GetChild(0).gameObject.activeInHierarchy || transform.GetChild(1).gameObject.activeInHierarchy))
        {
        MaviTop = true;
            Char1Col.YesilTop = false;
            Char2Col.SariTop = false;
        }
    }
    void Update()
    {
        if (transform.GetChild(0).gameObject.activeInHierarchy || transform.GetChild(1).gameObject.activeInHierarchy)
        {
            OyuncuAyar.MaviTopBariyerleriAktifMi = true;
        }
        else
        {
            OyuncuAyar.MaviTopBariyerleriAktifMi = false;
        }

        if (transform.GetChild(0).gameObject.activeInHierarchy)
        {
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMesh>().text = Mavi_Top_HareketSayisi_5.ToString(); ;
        }
        if (transform.GetChild(1).gameObject.activeInHierarchy)
        {
            transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMesh>().text = Mavi_Top_HareketSayisi_3.ToString(); ;
        }
        if (Mavi_Top_HareketSayisi_5 == 0 && !Top_BlockHakkiBitti_1)
        {
            CharController3.MaviTopEngeli_Kalkiyor = true;
            
            Invoke("Mavi_Locker_AnimFalse_1", 0.1f);
            Invoke("Mavi_Locker_GameObjectFalse_1", 1.25f);
            Invoke("Karakter3_HareketEngellemesi_Coz", 0.1f);

            Top_BlockHakkiBitti_1 = true;
        }
        if (Mavi_Top_HareketSayisi_3 == 0 && !Top_BlockHakkiBitti_2)
        {
            CharController3.MaviTopEngeli_Kalkiyor = true;
            
            Invoke("Mavi_Locker_AnimFalse_2", 0.1f);
            Invoke("Mavi_Locker_GameObjectFalse_2", 1.25f);
            Invoke("Karakter3_HareketEngellemesi_Coz", 0.1f);

            Top_BlockHakkiBitti_2 = true;
        }

        if (OyunMenu.Karakterler_IsTrigger)
        {
            Karakter3.isTrigger = true;

        }
        else
        {
            Karakter3.isTrigger = false;
        }

        if ((Input.GetMouseButton(0) || AnaMenu.Gosterge == 1) && OyunMenu.MenuAcildimi != 1 && OyunMenu.KarakterHareketGostergeAktif)
        {

            ArrowSlide = true;
            BallsHide = false;
            // 1.3 saniye sonra görünmeye başlar
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            if (timer <= 0.3f)
            {
                if (!CharController3.YukariGidisEngeli3 && CharController3.CharControlYukari3)
                {
                    Yukari.SetActive(true);
                }
                else
                {
                    Yukari.SetActive(false);
                }

                if (!CharController3.AsagiGidisEngeli3 && CharController3.CharControlAsagi3)
                {
                    Asagi.SetActive(true);
                }
                else
                {
                    Asagi.SetActive(false);
                }

                if (!CharController3.SagaGidisEngeli3 && CharController3.CharControlSag3)
                {
                    Sag.SetActive(true);
                }
                else
                {
                    Sag.SetActive(false);
                }

                if (!CharController3.SolaGidisEngeli3 && CharController3.CharControlSol3)
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
