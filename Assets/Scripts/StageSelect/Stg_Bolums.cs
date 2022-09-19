using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stg_Bolums : MonoBehaviour
{
    public Color Soluk_Kirmizi, Yesil, Soluk_Yesil;

    public Sprite Parildayan_Circle;
    public Sprite Parildamayan_Circle;

    public int BolumNumarasi;

    void Start()
    {
        BolumNumarasi = int.Parse(transform.name.Substring(5, transform.name.Length - 5));
    }
    void Update()
    {
        StgNew.OyuncununGectigiBolumler = PlayerPrefs.GetInt("OyuncununGectigiBolumler");


        transform.GetChild(1).gameObject.GetComponent<Text>().fontSize = Screen.width / 17;

        if (StgNew.OyuncununGectigiBolumler > BolumNumarasi)
        {

            transform.GetComponent<Button>().interactable = true;

            // Tick
            transform.GetChild(3).gameObject.SetActive(true);

            // Lock
            transform.GetChild(2).gameObject.SetActive(false);

            // Text
            transform.GetChild(1).gameObject.SetActive(true);

            // Img
            transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Parildayan_Circle;

            //Img Kenarlik
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = Soluk_Yesil;

            //Img Kenarlik - Anim
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Animator>().enabled = false;
        }

        else if (StgNew.OyuncununGectigiBolumler == BolumNumarasi)
        {
            transform.GetComponent<Button>().interactable = true;

            // Tick
            transform.GetChild(3).gameObject.SetActive(false);

            // Lock
            transform.GetChild(2).gameObject.SetActive(false);

            // Text
            transform.GetChild(1).gameObject.SetActive(true);

            // Img
            transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Parildayan_Circle;

            //Img Kenarlik
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = Yesil;

            //Img Kenarlik - Anim
          // NO STOP  transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Animator>().Stop();
        }

        else
        {
            transform.GetComponent<Button>().interactable = false;

            // Tick
            transform.GetChild(3).gameObject.SetActive(false);

            // Lock
            transform.GetChild(2).gameObject.SetActive(true);

            // Text
            transform.GetChild(1).gameObject.SetActive(false);

            // Img
            transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Parildamayan_Circle;

            //Img Kenarlik
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = Soluk_Kirmizi;

            //Img Kenarlik - Anim
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Animator>().enabled = false;
        }
    }
}
