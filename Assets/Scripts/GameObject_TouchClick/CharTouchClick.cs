using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharTouchClick : MonoBehaviour {

    public static bool HardBallLockerActive;
    public static bool BallLockerActive;

    public static bool SecimIcinTopHareketEttimi;
    
    public static bool BallLockRemoverActive;

    public static bool HareketEdildi;

    bool HakBittiMi;

    bool BolumGecildi_KilitMoveGizle;

    void Start () {

        HakBittiMi = false;
        HareketEdildi = false;

        BolumGecildi_KilitMoveGizle = false;

        SecimIcinTopHareketEttimi = false;

        HardBallLockerActive = false;
        BallLockerActive = false;
        BallLockRemoverActive = false;

        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(3).gameObject.SetActive(false);
    }

    void BallLock_Move()
    {
        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

    void Update () {

        OyuncuAyar.HardBallLockerKullanim = PlayerPrefs.GetInt("HardBallLockerKullanimHakki");
        OyuncuAyar.BallLockerKullanim = PlayerPrefs.GetInt("BallLockerKullanimHakki");

        if (OyunMenu.BolumGecildi && !BolumGecildi_KilitMoveGizle)
        {
            Invoke("BallLock_Move", 1.6f);
            BolumGecildi_KilitMoveGizle = true;
        }

        if (OyuncuAyar.SinirsizHardBallBlocker != 1)
        {
            if (OyuncuAyar.HardBallLockerKullanim == 0 && !HakBittiMi && HardBallLockerActive)
            {
                Invoke("TopSecGostergeKapat", 0.25f);
                HakBittiMi = true;
            }
        }
        if (OyuncuAyar.SinirsizBallBlocker != 1)
        {
            if (OyuncuAyar.BallLockerKullanim == 0 && !HakBittiMi && HardBallLockerActive)
            {
                Invoke("TopSecGostergeKapat", 0.25f);
                HakBittiMi = true;
            }
        }

        if (SecimIcinTopHareketEttimi)
        {
            HardBallLockerActive = false;
            BallLockerActive = false;
            BallLockRemoverActive = false;
        }
        
        if (HardBallLockerActive && (!transform.GetChild(0).gameObject.activeInHierarchy && !transform.GetChild(1).gameObject.activeInHierarchy))
        {
           transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(false);
        }
        else if (BallLockerActive && (!transform.GetChild(0).gameObject.activeInHierarchy && !transform.GetChild(1).gameObject.activeInHierarchy))
        {
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(false);
        }
        else if (BallLockRemoverActive && (transform.GetChild(0).gameObject.activeInHierarchy || transform.GetChild(1).gameObject.activeInHierarchy))
        {
            transform.GetChild(3).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(false);
        }
        else
        {
            transform.GetChild(2).gameObject.SetActive(false);
            transform.GetChild(3).gameObject.SetActive(false);
        }

    }

    void OnMouseDown()
    {
        if (!OyuncuAyar.BagAcik)
        {
            if (HardBallLockerActive && (!transform.GetChild(0).gameObject.activeInHierarchy && !transform.GetChild(1).gameObject.activeInHierarchy))
            {
                if (OyuncuAyar.HardBallLockerKullanim > 0 || OyuncuAyar.SinirsizHardBallBlocker == 1)
                {
                    transform.GetChild(0).gameObject.SetActive(true);

                    if (OyuncuAyar.SinirsizHardBallBlocker != 1)
                    {
                        OyuncuAyar.HardBallLockerKullanim -= 1;
                        PlayerPrefs.SetInt("HardBallLockerKullanimHakki", OyuncuAyar.HardBallLockerKullanim);
                    }

                    Invoke("HBLockingDelay", 0.1f);

                    if (!OyuncuAyar.Multiple)
                    {
                        Invoke("TopSecGostergeKapat", 0.25f);
                    }
                }
            }
            else if (BallLockerActive && (!transform.GetChild(0).gameObject.activeInHierarchy && !transform.GetChild(1).gameObject.activeInHierarchy))
            {
                if (OyuncuAyar.BallLockerKullanim > 0 || OyuncuAyar.SinirsizBallBlocker == 1) {
                    transform.GetChild(1).gameObject.SetActive(true);

                    if (OyuncuAyar.SinirsizBallBlocker != 1)
                    {
                        OyuncuAyar.BallLockerKullanim -= 1;
                        PlayerPrefs.SetInt("BallLockerKullanimHakki", OyuncuAyar.BallLockerKullanim);
                    }

                    Invoke("BLockingDelay", 0.1f);

                    if (!OyuncuAyar.Multiple)
                    {
                        Invoke("TopSecGostergeKapat", 0.25f);
                    }
                }
            }
            else if (BallLockRemoverActive && (transform.GetChild(0).gameObject.activeInHierarchy || transform.GetChild(1).gameObject.activeInHierarchy))
            {
                Invoke("RemovingDelay", 0);

                if (!OyuncuAyar.Multiple)
                {
                    Invoke("TopSecGostergeKapat", 0.25f);
                }
            }
        }
    }

    // FOR HARD BALL BLOCKER
    void HBLockingDelay()
    {
        transform.GetChild(0).gameObject.GetComponent<Animator>().Play("BirinciCubuk", -1, 0f);
    }

    // FOR BALL BLOCKER
    void BLockingDelay()
    {
        transform.GetChild(1).gameObject.GetComponent<Animator>().Play("BirinciCubuk", -1, 0f);
    }

    void RemovingDelay()
    {
        if (Char1Col.YesilTop)
        {
            if (transform.GetChild(0).gameObject.activeInHierarchy)
            {
                Char1Col.Yesil_Top_HareketSayisi_5 = 0;
                   Char1Col.Top_BlockHakkiBitti_1 = false;
            }
            if (transform.GetChild(1).gameObject.activeInHierarchy)
            {
                Char1Col.Yesil_Top_HareketSayisi_3 = 0;
                Char1Col.Top_BlockHakkiBitti_2 = false;
            }
        }
        else if (Char2Col.SariTop)
        {
            if (transform.GetChild(0).gameObject.activeInHierarchy)
            {
                Char2Col.Sari_Top_HareketSayisi_5 = 0;
                Char2Col.Top_BlockHakkiBitti_1 = false;
            }
            if (transform.GetChild(1).gameObject.activeInHierarchy)
            {
                Char2Col.Sari_Top_HareketSayisi_3 = 0;
                Char2Col.Top_BlockHakkiBitti_2 = false;
            }
        }
        else if (Char3Col.MaviTop)
        {
            if (transform.GetChild(0).gameObject.activeInHierarchy)
            {
                Char3Col.Mavi_Top_HareketSayisi_5 = 0;
                Char3Col.Top_BlockHakkiBitti_1 = false;
            }
            if (transform.GetChild(1).gameObject.activeInHierarchy)
            {
                Char3Col.Mavi_Top_HareketSayisi_3 = 0;
                Char3Col.Top_BlockHakkiBitti_2 = false;
            }
        }
    }

    void TopSecGostergeKapat()
    {
        BallLockerActive = false;
        HardBallLockerActive = false;
        BallLockRemoverActive = false;

        HakBittiMi = false;
    }

}
