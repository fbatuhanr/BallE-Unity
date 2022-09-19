using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//BATUHAN OZTURK
// 07.02.17 - 14.10
public class Magaza_WallCreatorBreaker : MonoBehaviour {

    int WallCreator_Miktar;
    int WallBreaker_Miktar;

	void Start () {

        WallCreator_Miktar = 1;
        WallBreaker_Miktar = 1;

    }
	
	void Update ()
    {
        OyuncuAyar.WallCreatorKullanim = PlayerPrefs.GetInt("WallCreatorKullanimHakki");
        OyuncuAyar.WallBreakerKullanim = PlayerPrefs.GetInt("WallBreakerKullanimHakki");
        transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = OyuncuAyar.WallCreatorKullanim.ToString();
        transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = OyuncuAyar.WallBreakerKullanim.ToString();
            
        transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 28;
        transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 28;


        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 28;
        transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 28;

        transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().fontSize = Screen.width / 24;
        transform.GetChild(1).gameObject.transform.GetChild(3).gameObject.GetComponent<Text>().fontSize = Screen.width / 24;


        transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = WallCreator_Miktar.ToString();
        transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 23;

        transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = (20 * WallCreator_Miktar).ToString();
        transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().fontSize = Screen.width / 16;

        transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = WallBreaker_Miktar.ToString();
        transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 23;

        transform.GetChild(1).gameObject.transform.GetChild(4).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = (15 * WallBreaker_Miktar).ToString();
        transform.GetChild(1).gameObject.transform.GetChild(4).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().fontSize = Screen.width / 16;
    }
    
    public void WallCreator_SatinAl()
    {
        if (OyuncuAyar.Para >= (20 * WallCreator_Miktar))
        {
            OyuncuAyar.Para -= (20 * WallCreator_Miktar);
            PlayerPrefs.SetInt("Para", OyuncuAyar.Para);

            OyuncuAyar.WallCreatorKullanim += WallCreator_Miktar;
            PlayerPrefs.SetInt("WallCreatorKullanimHakki", OyuncuAyar.WallCreatorKullanim);
        }
        else
        {
            ButonEksikPara();
        }
    }

    public void WallBreaker_SatinAl()
    {
        if (OyuncuAyar.Para >= (15 * WallBreaker_Miktar))
        {
            OyuncuAyar.Para -= (15 * WallBreaker_Miktar);
            PlayerPrefs.SetInt("Para", OyuncuAyar.Para);

            OyuncuAyar.WallBreakerKullanim += WallBreaker_Miktar;
            PlayerPrefs.SetInt("WallBreakerKullanimHakki", OyuncuAyar.WallBreakerKullanim);
        }
        else
        {
            ButonEksikPara();
        }
    }

    public void WallCreatorMiktar_Plus()
    {
            WallCreator_Miktar += 1;   
    }
    public void WallCreatorMiktar_Minus()
    {
        if (WallCreator_Miktar > 0)
        {
            WallCreator_Miktar -= 1;
        }
    }

    public void WallBreakerMiktar_Plus()
    {
        WallBreaker_Miktar += 1;
    }
    public void WallBreakerMiktar_Minus()
    {
        if (WallBreaker_Miktar > 0)
        {
            WallBreaker_Miktar -= 1;
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
