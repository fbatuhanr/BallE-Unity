using UnityEngine;
using System.Collections;
// BATUHAN OZTURK 26.12.26
public class Char2Col : MonoBehaviour {

    // OYUN MENÜSÜNDEN ULAŞMAK İÇİN TOPLAR ÜZERİNDE BULUNAN KARAKTER 2.COLLİDER ERİŞİMİNİ SAĞLAMAK AMACIYLA OLUŞTURULAN SCRIPT
    // HATIRLATMA CHAR 2 SARI TOP

    bool ArrowSlide, BallsHide;

    public Animator YukariAnim, AsagiAnim, SagAnim, SolAnim;

    public GameObject Yukari, Asagi, Sag, Sol;

    public static Transform Character2;
        Collider Karakter2;

    float timer;

    public static int Sari_Top_HareketSayisi_5, Sari_Top_HareketSayisi_3;

    public static bool Top_BlockHakkiBitti_1, Top_BlockHakkiBitti_2;

    public static bool SariTop;

    void Start()
    {

        SariTop = false;

        Top_BlockHakkiBitti_1 = false;
        Top_BlockHakkiBitti_2 = false;

        Sari_Top_HareketSayisi_5 = 10;
         Sari_Top_HareketSayisi_3 = 5;

        Character2 = GetComponent<Transform>();
        Karakter2 = GetComponent<Collider>();

        timer = 1.25f;

        Karakter2.isTrigger = true;

        ArrowSlide = false;
        BallsHide = true;
    }
    void Sari_Locker_AnimFalse_1()
    {
        transform.GetChild(0).gameObject.GetComponent<Animator>().Play("BirinciCubukGeriDonus", -1, 0f);
    }
    void Sari_Locker_GameObjectFalse_1()
    {
        transform.GetChild(0).gameObject.SetActive(false);

        Top_BlockHakkiBitti_1 = false;

        CharController2.SariTopEngeli_Kalkiyor = false;

        Sari_Top_HareketSayisi_5 = 10;
    }
    void Sari_Locker_AnimFalse_2()
    {
        transform.GetChild(1).gameObject.GetComponent<Animator>().Play("BirinciCubukGeriDonus", -1, 0f);
    }
    void Sari_Locker_GameObjectFalse_2()
    {
        transform.GetChild(1).gameObject.SetActive(false);

        Top_BlockHakkiBitti_2 = false;

        CharController2.SariTopEngeli_Kalkiyor = false;

        Sari_Top_HareketSayisi_3 = 5;
    }

    void Karakter2_HareketEngellemesi_Coz()
    {
        CharController2.YukariGidisEngeli2 = false;
        CharController2.AsagiGidisEngeli2 = false;
        CharController2.SolaGidisEngeli2 = false;
        CharController2.SagaGidisEngeli2 = false;
    }

    void OnMouseDown()
    {
        if (CharTouchClick.BallLockRemoverActive && (transform.GetChild(0).gameObject.activeInHierarchy || transform.GetChild(1).gameObject.activeInHierarchy))
        {
          SariTop = true;
            Char1Col.YesilTop = false;
            Char3Col.MaviTop = false;
        }      
    }

    void Update()
    {
        if (transform.GetChild(0).gameObject.activeInHierarchy || transform.GetChild(1).gameObject.activeInHierarchy)
        {
            OyuncuAyar.SariTopBariyerleriAktifMi = true;
        }
        else
        {
            OyuncuAyar.SariTopBariyerleriAktifMi = false;
        }

        if (transform.GetChild(0).gameObject.activeInHierarchy)
        {
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMesh>().text = Sari_Top_HareketSayisi_5.ToString(); ;
        }
        if (transform.GetChild(1).gameObject.activeInHierarchy)
        {
            transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMesh>().text = Sari_Top_HareketSayisi_3.ToString(); ;
        }
        if (Sari_Top_HareketSayisi_5 == 0 && !Top_BlockHakkiBitti_1)
        {
            CharController2.SariTopEngeli_Kalkiyor = true;

            Invoke("Sari_Locker_AnimFalse_1", 0.1f);
            Invoke("Sari_Locker_GameObjectFalse_1", 1.25f);
            Invoke("Karakter2_HareketEngellemesi_Coz", 0.1f);

            Top_BlockHakkiBitti_1 = true;
        }
        if (Sari_Top_HareketSayisi_3 == 0 && !Top_BlockHakkiBitti_2)
        {
            CharController2.SariTopEngeli_Kalkiyor = true;

            Invoke("Sari_Locker_AnimFalse_2", 0.1f);
            Invoke("Sari_Locker_GameObjectFalse_2", 1.25f);
            Invoke("Karakter2_HareketEngellemesi_Coz", 0.1f);

            Top_BlockHakkiBitti_2 = true;
        }

        if (OyunMenu.Karakterler_IsTrigger)
        {

          Karakter2.isTrigger = true;

        }
        else
        {
            Karakter2.isTrigger = false;
        }

        // OK GOSTERIM AYAR BASLANGIC

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
                if (!CharController2.YukariGidisEngeli2 && CharController2.CharControlYukari2)
                {
                    Yukari.SetActive(true);
                }
                else
                {
                    Yukari.SetActive(false);
                }

                if (!CharController2.AsagiGidisEngeli2 && CharController2.CharControlAsagi2)
                {
                    Asagi.SetActive(true);
                }
                else
                {
                    Asagi.SetActive(false);
                }

                if (!CharController2.SagaGidisEngeli2 && CharController2.CharControlSag2)
                {
                    Sag.SetActive(true);
                }
                else
                {
                    Sag.SetActive(false);
                }

                if (!CharController2.SolaGidisEngeli2 && CharController2.CharControlSol2)
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

            if (ArrowSlide) {
                 Invoke("ArrowSlideKapanis",0);             
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
