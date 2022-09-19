using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// BATUHAN OZTURK 06.02.17

// Select your barrier Colors

public class Magaza_Bariyer : MonoBehaviour {

    public Material Engel;

    Color Red, Orange, Yellow, Green, Aqua, Blue, Purple, Pink, White;

    public static int Mevcut_BarrierColors;

    public static int[] Colors = new int[9];

    public static int[] Bariyer_Fiyat = new int[9];

    void Start()
    {
        Red = transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color;
        Orange = transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color;
        Yellow = transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color;
        Green = transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color;
        Aqua = transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color;
        Blue = transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color;
        Purple = transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color;
        Pink = transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(7).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color;
        White = transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(8).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color;
    }

	void Update () {

        OyuncuAyar.Para = PlayerPrefs.GetInt("Para");
        Mevcut_BarrierColors = PlayerPrefs.GetInt("Mevcut_BariyerRengi");

        for (int i = 0; i <= 8; i++)
        {
           Colors[i] = PlayerPrefs.GetInt("Barrier_Renk_" + i.ToString());
        }

        switch (Mevcut_BarrierColors)
        {
            case 0:
                // Kirmizi
                Engel.color = Red;

                for (int i = 0; i<= 8; i++)
                {
                    if (i == 0)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(true);
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                    }
                }
                break;

            case 1:
                // Turuncu
                Engel.color = Orange;

                for (int i = 0; i <= 8; i++)
                {
                    if (i == 1)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(true);
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                    }
                }
                break;

            case 2:
                // Sari
                Engel.color = Yellow;

                for (int i = 0; i <= 8; i++)
                {
                    if (i == 2)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(true);
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                    }
                }
                break;

            case 3:
                // Yesil
                Engel.color = Green; 

                for (int i = 0; i <= 8; i++)
                {
                    if (i == 3)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(true);
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                    }
                }
                break;

            case 4:
                //  Aqua
                Engel.color = Aqua;

                for (int i = 0; i <= 8; i++)
                {
                    if (i == 4)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(true);
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                    }
                }
                break;

            case 5:
                // Mavi
                Engel.color = Blue;

                for (int i = 0; i <= 8; i++)
                {
                    if (i == 5)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(true);
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                    }
                }
                break;

            case 6:
                // Mor
                Engel.color = Purple;

                for (int i = 0; i <= 8; i++)
                {
                    if (i == 6)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(true);
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                    }
                }
                break;

            case 7:
                // Pink
                Engel.color = Pink;

                for (int i = 0; i <= 8; i++)
                {
                    if (i == 7)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(true);
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                    }
                }
                break;
            case 8:
                // Beyaz
                Engel.color = White;

                for (int i = 0; i <= 8; i++)
                {
                    if (i == 8)
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(true);
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                    }
                }
                break;

            default:
                // Default Red
                Engel.color = Red;

                for (int i = 0; i<= 8; i++) {
                    if (i == 0) {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(true);
                    }
                    else
                    {
                        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(false);
                    }
                }
                break;
        }


        for (int i = 0; i<= 8; i++)
        {
            if (i == 0) {

                transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(3).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().fontSize = Screen.width / 26;

                transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(3).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;

                if (transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.activeInHierarchy)
                {
                    transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(3).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Selected";
                }
                else
                {
                    transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(3).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Select";
                }

                transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.SetActive(false);

                transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(5).gameObject.SetActive(false);
            }
            else
            {
                transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(3).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().fontSize = Screen.width / 26;
                if (Colors[i] == 1) {
                    Bariyer_Fiyat[i] = 0;
                    
                        if (transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.activeInHierarchy)
                        {
                            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(3).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Selected";
                        }
                        else
                        {
                            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(3).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Select";
                    }
                    transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(3).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
                    transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.SetActive(false);

                    
                    transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(5).gameObject.SetActive(false);
                }
                else {
                    Bariyer_Fiyat[i] = 120;
                    transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(3).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "120";

                    transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(3).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().alignment = TextAnchor.MiddleRight;

                    transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.SetActive(true);

                    transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(5).gameObject.SetActive(true);
                }
            }      
        }

        for (int i = 0; i <= 8; i++)
        {
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().fontSize = Screen.width / 40;

            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 28;    
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().fontSize = Screen.width / 30;
        }



    }

    public void Buy_BarrierColors(int code)
    {
        if (OyuncuAyar.Para >= Bariyer_Fiyat[code])
        {
            OyuncuAyar.Para -= Bariyer_Fiyat[code];
            PlayerPrefs.SetInt("Para", OyuncuAyar.Para);

            Colors[code] = 1;
            PlayerPrefs.SetInt("Barrier_Renk_"+ code.ToString(), 1);

            Mevcut_BarrierColors = code;
            PlayerPrefs.SetInt("Mevcut_BariyerRengi", Mevcut_BarrierColors);

        }
        else
        {
            ButonEksikPara();
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
