using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//BATUHAN OZTURK 07..02.17 - 15.40

public class Magaza_BallBlocker : MonoBehaviour {

    int HardBallBlocker_Adet;
    int BallBlocker_Adet;

    void Start()
    {

        HardBallBlocker_Adet = 1;
        BallBlocker_Adet = 1;

    }

    void Update()
    {
        OyuncuAyar.HardBallLockerKullanim = PlayerPrefs.GetInt("HardBallLockerKullanimHakki");
        OyuncuAyar.BallLockerKullanim = PlayerPrefs.GetInt("BallLockerKullanimHakki");

        transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 26;
        transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 26;

        transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = OyuncuAyar.HardBallLockerKullanim.ToString();
        transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = OyuncuAyar.BallLockerKullanim.ToString();

        transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 28;
        transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 28;


        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 34;
        transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 30;

        transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().fontSize = Screen.width / 24;
        transform.GetChild(1).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().fontSize = Screen.width / 24;


        transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = HardBallBlocker_Adet.ToString();
        transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 23;

        transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = (40 * HardBallBlocker_Adet).ToString();
        transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().fontSize = Screen.width / 16;

        transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = BallBlocker_Adet.ToString();
        transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 23;

        transform.GetChild(1).gameObject.transform.GetChild(4).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = (30 * BallBlocker_Adet).ToString();
        transform.GetChild(1).gameObject.transform.GetChild(4).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().fontSize = Screen.width / 16;
    }

    public void HardBallBlocker_SatinAl()
    {
        if (OyuncuAyar.Para >= (40 * HardBallBlocker_Adet))
        {
            OyuncuAyar.Para -= (40 * HardBallBlocker_Adet);
            PlayerPrefs.SetInt("Para", OyuncuAyar.Para);

            OyuncuAyar.HardBallLockerKullanim += HardBallBlocker_Adet;
            PlayerPrefs.SetInt("HardBallLockerKullanimHakki", OyuncuAyar.HardBallLockerKullanim);
        }
        else
        {
            ButonEksikPara();
        }
    }

    public void BallBlocker_SatinAl()
    {
        if (OyuncuAyar.Para >= (30 * BallBlocker_Adet))
        {
            OyuncuAyar.Para -= (30 * BallBlocker_Adet);
            PlayerPrefs.SetInt("Para", OyuncuAyar.Para);

            OyuncuAyar.BallLockerKullanim += BallBlocker_Adet;
            PlayerPrefs.SetInt("BallLockerKullanimHakki", OyuncuAyar.BallLockerKullanim);
        }
        else
        {
            ButonEksikPara();
        }
    }

    public void HardBallLockerMiktar_Plus()
    {
        HardBallBlocker_Adet += 1;
    }
    public void HardBallLockerMiktar_Minus()
    {
        if (HardBallBlocker_Adet > 1)
        {
            HardBallBlocker_Adet -= 1;
        }
    }

    public void BallLockerMiktar_Plus()
    {
       BallBlocker_Adet += 1;
    }
    public void BallLockerMiktar_Minus()
    {
        if (BallBlocker_Adet > 1)
        {
            BallBlocker_Adet -= 1;
        }
    }

    void ButonEksikPara()
    {
        transform.parent.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        transform.parent.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        transform.parent.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        transform.parent.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        transform.parent.gameObject.transform.GetChild(4).gameObject.SetActive(false);
        transform.parent.gameObject.transform.GetChild(5).gameObject.SetActive(true);

        transform.parent.gameObject.transform.parent.gameObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Button>().interactable = true;

        transform.parent.gameObject.transform.parent.gameObject.transform.GetChild(3).gameObject.transform.GetChild(1).gameObject.GetComponent<Button>().interactable = true;
        transform.parent.gameObject.transform.parent.gameObject.transform.GetChild(3).gameObject.transform.GetChild(2).gameObject.GetComponent<Button>().interactable = true;
        transform.parent.gameObject.transform.parent.gameObject.transform.GetChild(3).gameObject.transform.GetChild(3).gameObject.GetComponent<Button>().interactable = true;
        transform.parent.gameObject.transform.parent.gameObject.transform.GetChild(3).gameObject.transform.GetChild(4).gameObject.GetComponent<Button>().interactable = true;
        transform.parent.gameObject.transform.parent.gameObject.transform.GetChild(3).gameObject.transform.GetChild(5).gameObject.GetComponent<Button>().interactable = false;
    } 
}
