using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Batuhan OZTURK 30.01.27

public class BarrierTouch_Child : MonoBehaviour {

    public GameObject Dikey_Bariyer,Yatay_Bariyer;

    public bool WC_BarrierUstu_Spawn;

    bool Barrier_DestroyAnim;

    double DikeyBariyer_x_Yuvarlama, DikeyBariyer_y_Yuvarlama;
    float DikeyBariyer_x, DikeyBariyer_y;

    double YatayBariyer_x_Yuvarlama, YatayBariyer_y_Yuvarlama;
    float YatayBariyer_x, YatayBariyer_y;

    GameObject DestroyEdilecek;

    public static bool GostergelerSaydamlasiyor;

    bool HakBittiMi;

    void Start()
    {
        HakBittiMi = false;
        transform.GetChild(0).gameObject.SetActive(false);
        GostergelerSaydamlasiyor = false;
        WC_BarrierUstu_Spawn = false;
        Barrier_DestroyAnim = false;
    }

    void Update()
    {
        OyuncuAyar.WallCreatorKullanim = PlayerPrefs.GetInt("WallCreatorKullanimHakki");
        OyuncuAyar.WallBreakerKullanim = PlayerPrefs.GetInt("WallBreakerKullanimHakki");

        AnaMenu.Bolum = PlayerPrefs.GetInt("OyuncuHangiBolumdeKaldi");

        if (Barrier_DestroyAnim)
        {
            DestroyEdilecek.transform.localPosition += new Vector3(0, 0, 0.018f);
        }

        if (OyuncuAyar.SinirsizWallBreaker != 1)
        {
            if (OyuncuAyar.WallBreakerKullanim == 0 && !HakBittiMi && BarrierTouchClick.WallBreaker) {
                GostergelerSaydamlasiyor = true;
                Invoke("GostergeKapat", 1.5f);
                HakBittiMi = true;
            }
        }
        if (OyuncuAyar.SinirsizWallCreator != 1)
        {
            if (OyuncuAyar.WallCreatorKullanim == 0 && !HakBittiMi && BarrierTouchClick.WallCreator)
            {
                GostergelerSaydamlasiyor = true;
                Invoke("GostergeKapat", 1.5f);
                HakBittiMi = true;
            }
        }
    }

    void OnMouseDown()
    {
        if (!OyuncuAyar.BagAcik) {
            if (BarrierTouchClick.WallCreator)
            {
                if (OyuncuAyar.WallCreatorKullanim > 0 || OyuncuAyar.SinirsizWallCreator == 1)
                {

                    Bolumler_Ustu_Dikey_Yatay_BariyerDoseme_Ayar();

                    if (OyuncuAyar.SinirsizWallCreator != 1)
                    {
                        OyuncuAyar.WallCreatorKullanim -= 1;
                        PlayerPrefs.SetInt("WallCreatorKullanimHakki", OyuncuAyar.WallCreatorKullanim);
                    }
                    if (!OyuncuAyar.Multiple)
                    {
                        GostergelerSaydamlasiyor = true;
                        Invoke("GostergeKapat", 1.5f);
                    }
                }
            }
            else if (BarrierTouchClick.WallBreaker)
            {
                if (OyuncuAyar.WallBreakerKullanim > 0 || OyuncuAyar.SinirsizWallBreaker == 1)
                {
                    transform.GetChild(0).gameObject.SetActive(true);

                    Barrier_DestroyAnim = true;
                    Invoke("Barrier_DestroyAnimFalse", 1.4f);

                    if (OyuncuAyar.SinirsizWallBreaker != 1) { 

                    OyuncuAyar.WallBreakerKullanim -= 1;
                    PlayerPrefs.SetInt("WallBreakerKullanimHakki", OyuncuAyar.WallBreakerKullanim);

                    }

                    if (!OyuncuAyar.Multiple)
                    {
                        GostergelerSaydamlasiyor = true;
                        Invoke("GostergeKapat", 1.5f);
                    }
                }
            }
        }
    }
    void Barrier_DestroyAnimFalse()
    {
        Barrier_DestroyAnim = false;
        Destroy(DestroyEdilecek);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        WC_BarrierUstu_Spawn = false;
    }

    void GostergeKapat()
    {
        BarrierTouchClick.WallCreator = false;
        BarrierTouchClick.WallBreaker = false;
        GostergelerSaydamlasiyor = false;

        HakBittiMi = false;
    }

    void OnTriggerEnter(Collider Wall_BariyerTeget)
    {
        if (Wall_BariyerTeget.gameObject.tag == "BariyerVar")
        {
           WC_BarrierUstu_Spawn = true;
           DestroyEdilecek = Wall_BariyerTeget.gameObject;         
        }
    }

    void OnTriggerExit(Collider Wall_BariyerAyrim)
    {
        if (Wall_BariyerAyrim.gameObject.tag == "BariyerVar")
        {
            WC_BarrierUstu_Spawn = false;
        }
    }

    void Bolumler_Ustu_Dikey_Yatay_BariyerDoseme_Ayar()
    {
        if (transform.parent.gameObject.name == "DikeyEngel_GostergeNoktalari")
        {
            DikeyBariyer_y_Yuvarlama = transform.position.y;
            DikeyBariyer_y_Yuvarlama = System.Math.Round(DikeyBariyer_y_Yuvarlama, 1);



            if (AnaMenu.Bolum >= 1 && AnaMenu.Bolum <= 20)
            {
                if (DikeyBariyer_y_Yuvarlama == -4.7)
                {
                    DikeyBariyer_y = -4.618313f;
                }
                else if (DikeyBariyer_y_Yuvarlama == -3.2)
                {
                    DikeyBariyer_y = -3.149434f;
                }
                else if (DikeyBariyer_y_Yuvarlama == -1.7)
                {
                    DikeyBariyer_y = -1.688165f;
                }
                else if (DikeyBariyer_y_Yuvarlama == -0.3)
                {
                    DikeyBariyer_y = -0.2192845f;
                }
                else if (DikeyBariyer_y_Yuvarlama == 1.2)
                {
                    DikeyBariyer_y = 1.239448f;
                }
                else if (DikeyBariyer_y_Yuvarlama == 2.7)
                {
                    DikeyBariyer_y = 2.700717f;
                }
                else if (DikeyBariyer_y_Yuvarlama == 4.1)
                {
                    DikeyBariyer_y = 4.169596f;
                }
            }
            else if (AnaMenu.Bolum > 20 && AnaMenu.Bolum <= 43)
            {
                if (DikeyBariyer_y_Yuvarlama == -4.8)
                {
                    DikeyBariyer_y = -4.8f;
                }
                else if (DikeyBariyer_y_Yuvarlama == -3.7)
                {
                    DikeyBariyer_y = -3.654281f;
                }
                else if (DikeyBariyer_y_Yuvarlama == -2.5)
                {
                    DikeyBariyer_y = -2.496f;
                }
                else if (DikeyBariyer_y_Yuvarlama == -1.4)
                {
                    DikeyBariyer_y = -1.345679f;
                }
                else if (DikeyBariyer_y_Yuvarlama == -0.2)
                {
                    DikeyBariyer_y = -0.198f;
                }
                else if (DikeyBariyer_y_Yuvarlama == 0.9)
                {
                    DikeyBariyer_y = 0.9400904f;
                }
                else if (DikeyBariyer_y_Yuvarlama == 2.1)
                {
                    DikeyBariyer_y = 2.091855f;
                }
                else if (DikeyBariyer_y_Yuvarlama == 3.2)
                {
                    DikeyBariyer_y = 3.217f;
                }
                else if (DikeyBariyer_y_Yuvarlama == 4.3)
                {
                    DikeyBariyer_y = 4.373f;
                }
            }

            else if (AnaMenu.Bolum > 43)
            {

                if (DikeyBariyer_y_Yuvarlama == 4.4)
                {
                    DikeyBariyer_y = 4.45f;
                }
                else if (DikeyBariyer_y_Yuvarlama == 3.5)
                {
                    DikeyBariyer_y = 3.529f;
                }
                else if (DikeyBariyer_y_Yuvarlama == 2.6)
                {
                    DikeyBariyer_y = 2.591f;
                }
                else if (DikeyBariyer_y_Yuvarlama == 1.7)
                {
                    DikeyBariyer_y = 1.66f;
                }
                else if (DikeyBariyer_y_Yuvarlama == 0.7)
                {
                    DikeyBariyer_y = 0.725f;
                }
                else if (DikeyBariyer_y_Yuvarlama == -0.2)
                {
                    DikeyBariyer_y = -0.207f;
                }
                else if (DikeyBariyer_y_Yuvarlama == -1.1)
                {
                    DikeyBariyer_y = -1.145f;
                }
                else if (DikeyBariyer_y_Yuvarlama == -2.1)
                {
                    DikeyBariyer_y = -2.091f;
                }
                else if (DikeyBariyer_y_Yuvarlama == -3.1)
                {
                    DikeyBariyer_y = -3.04f;
                }
                else if (DikeyBariyer_y_Yuvarlama == -4)
                {
                    DikeyBariyer_y = -3.981f;
                }
                else if (DikeyBariyer_y_Yuvarlama == -4.9)
                {
                    DikeyBariyer_y = -4.9f;
                }
            }

            DikeyBariyer_x_Yuvarlama = transform.position.x;
            DikeyBariyer_x_Yuvarlama = System.Math.Round(DikeyBariyer_x_Yuvarlama, 1);

            if (AnaMenu.Bolum >= 1 && AnaMenu.Bolum <= 20)
            {
                if (DikeyBariyer_x_Yuvarlama == -1.4)
                {
                    DikeyBariyer_x = -1.439348f;
                }
                else if (DikeyBariyer_x_Yuvarlama == 0)
                {
                    DikeyBariyer_x = -0.009f;
                }
                else if (DikeyBariyer_x_Yuvarlama == 1.5)
                {
                    DikeyBariyer_x = 1.455067f;
                }
            }
            else if (AnaMenu.Bolum > 20 && AnaMenu.Bolum <= 43)
            {
                if (DikeyBariyer_x_Yuvarlama == -1.7)
                {
                    DikeyBariyer_x = -1.734f;
                }
                else if (DikeyBariyer_x_Yuvarlama == -0.6)
                {
                    DikeyBariyer_x = -0.582f;
                }
                else if (DikeyBariyer_x_Yuvarlama == 0.6)
                {
                    DikeyBariyer_x = 0.601f;
                }
                else if (DikeyBariyer_x_Yuvarlama == 1.8)
                {
                    DikeyBariyer_x = 1.7585f;
                }
            }

            else if (AnaMenu.Bolum > 43)
            {
                if (DikeyBariyer_x_Yuvarlama == -1.9)
                {
                    DikeyBariyer_x = -1.935f;
                }
                else if (DikeyBariyer_x_Yuvarlama == -1)
                {
                    DikeyBariyer_x = -0.968f;
                }
                else if (DikeyBariyer_x_Yuvarlama == 0)
                {
                    DikeyBariyer_x = 0.025f;
                }
                else if (DikeyBariyer_x_Yuvarlama == 1)
                {
                    DikeyBariyer_x = 0.997f;
                }
                else if (DikeyBariyer_x_Yuvarlama == 2)
                {
                    DikeyBariyer_x = 1.969f;
                }
            }

            if (AnaMenu.Bolum >= 1 && AnaMenu.Bolum <= 20)
            {
                GameObject DikeyBarrier = Instantiate(Dikey_Bariyer, new Vector3(DikeyBariyer_x, DikeyBariyer_y, -2.30063f), Quaternion.identity);
                DikeyBarrier.transform.localScale = new Vector3(0.1804311f, 0.6908181f, 0.3423437f);
                DikeyBarrier.transform.parent = GameObject.Find("Bolum_Barriers").transform;
            }
            else if (AnaMenu.Bolum > 20 && AnaMenu.Bolum <= 43)
            {
                GameObject DikeyBarrier = Instantiate(Dikey_Bariyer, new Vector3(DikeyBariyer_x, DikeyBariyer_y, -2.30063f), Quaternion.identity);
                DikeyBarrier.transform.localScale = new Vector3(0.1328173f, 0.5401393f, 0.2676728f);
                DikeyBarrier.transform.parent = GameObject.Find("Bolum_Barriers").transform;
            }
            else if (AnaMenu.Bolum > 43)
            {  
                GameObject DikeyBarrier = Instantiate(Dikey_Bariyer, new Vector3(DikeyBariyer_x, DikeyBariyer_y, -2.167401f), Quaternion.identity);
                DikeyBarrier.transform.localScale = new Vector3(0.1115561f, 0.4422437f, 0.2247789f);
                DikeyBarrier.transform.parent = GameObject.Find("Bolum_Barriers").transform;
            }

        }
        else if (transform.parent.gameObject.name == "YatayEngel_GostergeNoktalari")
        {
            YatayBariyer_y_Yuvarlama = transform.position.y;
            YatayBariyer_y_Yuvarlama = System.Math.Round(YatayBariyer_y_Yuvarlama, 1);

            if (AnaMenu.Bolum >= 1 && AnaMenu.Bolum <= 20)
            {
                if (YatayBariyer_y_Yuvarlama == -3.9)
                {
                    YatayBariyer_y = -3.887f;
                }
                else if (YatayBariyer_y_Yuvarlama == -2.4)
                {
                    YatayBariyer_y = -2.425f;
                }
                else if (YatayBariyer_y_Yuvarlama == -0.9)
                {
                    YatayBariyer_y = -0.951f;
                }
                else if (YatayBariyer_y_Yuvarlama == 0.5)
                {
                    YatayBariyer_y = 0.512f;
                }
                else if (YatayBariyer_y_Yuvarlama == 2.0)
                {
                    YatayBariyer_y = 1.955f;
                }
                else if (YatayBariyer_y_Yuvarlama == 3.4)
                {
                    YatayBariyer_y = 3.428f;
                }
            }
            else if (AnaMenu.Bolum > 20 && AnaMenu.Bolum <= 43)
            {
                if (YatayBariyer_y_Yuvarlama == -4.2)
                {
                    YatayBariyer_y = -4.228f;
                }
                else if (YatayBariyer_y_Yuvarlama == -3.1)
                {
                    YatayBariyer_y = -3.072f;
                }
                else if (YatayBariyer_y_Yuvarlama == -1.9)
                {
                    YatayBariyer_y = -1.916f;
                }
                else if (YatayBariyer_y_Yuvarlama == -0.8)
                {
                    YatayBariyer_y = -0.763f;
                }
                else if (YatayBariyer_y_Yuvarlama == 0.4)
                {
                    YatayBariyer_y = 0.3718193f;
                }
                else if (YatayBariyer_y_Yuvarlama == 1.5)
                {
                    YatayBariyer_y = 1.52612f;
                }
                else if (YatayBariyer_y_Yuvarlama == 2.6)
                {
                    YatayBariyer_y = 2.639831f;
                }
                else if (YatayBariyer_y_Yuvarlama == 3.8)
                {
                    YatayBariyer_y = 3.797f;
                }
            }

            else if (AnaMenu.Bolum > 43)
            {
                if (YatayBariyer_y_Yuvarlama == 4.0)
                {
                    YatayBariyer_y = 3.99f;
                }
                else if (YatayBariyer_y_Yuvarlama == 3.1)
                {
                    YatayBariyer_y = 3.06f;
                }
                else if (YatayBariyer_y_Yuvarlama == 2.1)
                {
                    YatayBariyer_y = 2.115f;
                }
                else if (YatayBariyer_y_Yuvarlama == 1.2)
                {
                    YatayBariyer_y = 1.2015f;
                }
                else if (YatayBariyer_y_Yuvarlama == 0.3)
                {
                    YatayBariyer_y = 0.2556f;
                }
                else if (YatayBariyer_y_Yuvarlama == -0.7)
                {
                    YatayBariyer_y = -0.6737f;
                }
                else if (YatayBariyer_y_Yuvarlama == -1.6)
                {
                    YatayBariyer_y = -1.6184f;
                }
                else if (YatayBariyer_y_Yuvarlama == -2.6)
                {
                    YatayBariyer_y = -2.5638f;
                }
                else if (YatayBariyer_y_Yuvarlama == -3.5)
                {
                    YatayBariyer_y = -3.5103f;
                }
                else if (YatayBariyer_y_Yuvarlama == -4.5)
                {
                    YatayBariyer_y = -4.4544f;
                }
            }

            YatayBariyer_x_Yuvarlama = transform.position.x;
            YatayBariyer_x_Yuvarlama = System.Math.Round(YatayBariyer_x_Yuvarlama, 1);

            if (AnaMenu.Bolum >= 1 && AnaMenu.Bolum <= 20)
            {
                if (YatayBariyer_x_Yuvarlama == -2.2)
                {
                    YatayBariyer_x = -2.162f;
                }
                else if (YatayBariyer_x_Yuvarlama == -0.7)
                {
                    YatayBariyer_x = -0.73f;
                }
                else if (YatayBariyer_x_Yuvarlama == 0.7)
                {
                    YatayBariyer_x = 0.72f;
                }
                else if (YatayBariyer_x_Yuvarlama == 2.2)
                {
                    YatayBariyer_x = 2.16f;
                }
            }

            else if (AnaMenu.Bolum > 20 && AnaMenu.Bolum <= 43)
            {
                if (YatayBariyer_x_Yuvarlama == -2.3)
                {
                    YatayBariyer_x = -2.316443f;
                }
                else if (YatayBariyer_x_Yuvarlama == -1.1)
                {
                    YatayBariyer_x = -1.158677f;
                }
                else if (YatayBariyer_x_Yuvarlama == 0)
                {
                    YatayBariyer_x = 0.009112597f;
                }
                else if (YatayBariyer_x_Yuvarlama == 1.2)
                {
                    YatayBariyer_x = 1.181914f;
                }
                else if (YatayBariyer_x_Yuvarlama == 2.4)
                {
                    YatayBariyer_x = 2.33f;
                }
            }

            else if (AnaMenu.Bolum > 43)
            {
                if (YatayBariyer_x_Yuvarlama == -2.4)
                {
                    YatayBariyer_x = -2.411f;
                }
                else if (YatayBariyer_x_Yuvarlama == -1.4)
                {
                    YatayBariyer_x = -1.451f;
                }
                else if (YatayBariyer_x_Yuvarlama == -0.5)
                {
                    YatayBariyer_x = -0.4747f;
                }
                else if (YatayBariyer_x_Yuvarlama == 0.5)
                {
                    YatayBariyer_x = 0.5105f;
                }
                else if (YatayBariyer_x_Yuvarlama == 1.5)
                {
                    YatayBariyer_x = 1.483f;
                }
                else if (YatayBariyer_x_Yuvarlama == 2.4)
                {
                    YatayBariyer_x = 2.44f;
                }
            }

            if (AnaMenu.Bolum >= 1 && AnaMenu.Bolum <= 20)
            {
                GameObject YatayBarrier = Instantiate(Yatay_Bariyer, new Vector3(YatayBariyer_x, YatayBariyer_y, -2.30063f), Quaternion.identity);
                YatayBarrier.transform.localScale = new Vector3(0.1804311f, 0.6908181f, 0.3423437f);
                YatayBarrier.transform.localRotation = Quaternion.Euler(0, 0, 270);
                YatayBarrier.transform.parent = GameObject.Find("Bolum_Barriers").transform;
            }
            else if (AnaMenu.Bolum > 20 && AnaMenu.Bolum <= 43)
            {
                GameObject YatayBarrier = Instantiate(Yatay_Bariyer, new Vector3(YatayBariyer_x, YatayBariyer_y, -2.30063f), Quaternion.identity);
                YatayBarrier.transform.localScale = new Vector3(0.1328173f, 0.5401393f, 0.2676728f);
                YatayBarrier.transform.localRotation = Quaternion.Euler(0, 0, 270);
                YatayBarrier.transform.parent = GameObject.Find("Bolum_Barriers").transform;
            }
            else if (AnaMenu.Bolum > 43)
            {    
                    GameObject YatayBarrier = Instantiate(Yatay_Bariyer, new Vector3(YatayBariyer_x, YatayBariyer_y, -2.167401f), Quaternion.identity);
                    YatayBarrier.transform.localScale = new Vector3(0.1115561f, 0.4422437f, 0.2247789f);
                    YatayBarrier.transform.localRotation = Quaternion.Euler(0, 0, 270);
                    YatayBarrier.transform.parent = GameObject.Find("Bolum_Barriers").transform;
            }
        }
    }

}
