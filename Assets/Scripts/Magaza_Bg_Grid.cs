using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// BATUHAN OZTURK
//07.02.17 02.00

public class Magaza_Bg_Grid : MonoBehaviour {

    public Material Grid, Border_Backgrounds;

    public Sprite Blue_Dotted, Red_Dotted, Yellow_Dotted, Orange_Dotted, Green_Dotted;

    public Color Standart_Mavi_Cartoon;

    Color Grey, Orange, Yellow, Green, Aqua, Blue, Purple, Pink, White;

    public static int Mevcut_GridColors;
    public static int[] Colors = new int[9];
    public static int[] Grid_Fiyat = new int[9];

    public static int Mevcut_BorderColors;
    public static int[] Border_Colors = new int[5];
    public static int[] Border_Fiyat = new int[5];

    public static int Mevcut_BackgroundColors;
    public static int[] BG_Colors = new int[5];
    public static int[] Background_Fiyat = new int[5];

    int Sayac_1, Sayac_2;

    void Start () {

        Sayac_1 = 0;
        Sayac_2 = 0;

        Grey = transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color;
        Orange = transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color;
        Yellow = transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color;
        Green = transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color;
        Aqua = transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color;
        Blue = transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(5).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color;
        Purple = transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(6).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color;
        Pink = transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(7).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color;
        White = transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(8).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color;
    }
	
	void Update ()
    {
        OyuncuAyar.Para = PlayerPrefs.GetInt("Para");
        Mevcut_GridColors = PlayerPrefs.GetInt("Mevcut_IzgaraRengi");
        Mevcut_BackgroundColors = PlayerPrefs.GetInt("Mevcut_BackgroundRengi");
        Mevcut_BorderColors = PlayerPrefs.GetInt("Mevcut_BorderRengi");

        for (int i = 0; i <= 8; i++)
        {
            Colors[i] = PlayerPrefs.GetInt("Grid_Renk_" + i.ToString());
        }
        for (int i = 0; i < 5; i++)
        {
            BG_Colors[i] = PlayerPrefs.GetInt("Bg_Renk_" + i.ToString());
        }
        for (int i = 0; i < 5; i++)
        {
            Border_Colors[i] = PlayerPrefs.GetInt("Border_Renk_" + i.ToString());
        }

        switch (Mevcut_GridColors)
        {
            case 0:
                // Kirmizi
                Grid.color = Grey;

                for (int i = 0; i <= 8; i++)
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
                Grid.color = Orange;

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
                Grid.color = Yellow;

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
                Grid.color = Green;

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
                Grid.color = Aqua;

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
                Grid.color = Blue;

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
                Grid.color = Purple;

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
                Grid.color = Pink;

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
                Grid.color = White;

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
                Grid.color = Grey;

                for (int i = 0; i <= 8; i++)
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
        }

        switch (Mevcut_BorderColors)
        {
            case 0:
                Border_Backgrounds.color = Standart_Mavi_Cartoon;
                break;
            case 1:
                Border_Backgrounds.color = Green;
                break;
            case 2:
                Border_Backgrounds.color = Orange;
                break;
            case 3:
                Border_Backgrounds.color = Color.red;
                break;
            case 4:
                Border_Backgrounds.color = Yellow;
                break;
        }
        switch (Mevcut_BackgroundColors)
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

        for (int i = 0; i <= 8; i++)
        {
            if (i == 0)
            {
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
                if (Colors[i] == 1)
                {
                    Grid_Fiyat[i] = 0;

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
                else
                {
                    Grid_Fiyat[i] = 100;
                    transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(3).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "100";

                    transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(3).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().alignment = TextAnchor.MiddleRight;

                    transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.SetActive(true);

                    transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(5).gameObject.SetActive(true);
                }
            }
        }

        for (int i = 0; i <= 8; i++)
        {
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().fontSize = Screen.width / 40;

            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 32;         
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.transform.GetChild(5).gameObject.GetComponent<Text>().fontSize = Screen.width / 31;
        }

        switch (Sayac_1)
        {
            case 0:
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = Standart_Mavi_Cartoon;
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Default Border";

                for (int i = 1; i<=7; i++)
                {
                    transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.GetComponent<Image>().color = Standart_Mavi_Cartoon;
                }

                transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(8).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Default Blue Border";

                break;
            case 1:
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = Green;
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Green Border";

                for (int i = 1; i <= 7; i++)
                {
                    transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.GetComponent<Image>().color = Green;
                }

                transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(8).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Green Border";

                break;
            case 2:
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = Orange;
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Orange Border";

                for (int i = 1; i <= 7; i++)
                {
                    transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.GetComponent<Image>().color = Orange;
                }
                
                transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(8).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Orange Border";

                break;
            case 3:
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = Color.red;
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Red Border";

                for (int i = 1; i <= 7; i++)
                {
                    transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.GetComponent<Image>().color = Color.red;
                }

                transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(8).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Red Border";

                break;
            case 4:
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = Yellow;
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Yellow Border";

                for (int i = 1; i <= 7; i++)
                {
                    transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.GetComponent<Image>().color = Yellow;
                }

                transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(8).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Yellow Border";

                break;
            default:
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = Standart_Mavi_Cartoon;
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Default Border";

                for (int i = 1; i <= 7; i++)
                {
                    transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(i).gameObject.GetComponent<Image>().color = Standart_Mavi_Cartoon;
                }

                transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(8).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Default Blue Border";

                break;
        }

        switch (Sayac_2)
        {
            case 0:
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Blue_Dotted;
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Blue_Dotted;
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Default Background";

                transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Default Bluish Background";

                break;

            case 1:
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Green_Dotted;
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Green_Dotted;
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Green Background";

                transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Greenish Background";
                break;

            case 2:
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Orange_Dotted;
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Orange_Dotted;
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Orange Background";

                transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Orange Background";
                break;

            case 3:
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Red_Dotted;
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Red_Dotted;
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Red Background";

                transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Reddish Background";
                break;

            case 4:
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Yellow_Dotted;
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Yellow_Dotted;
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Yellow Background";

                transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Yellowish Background";
                break;

            default:
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Blue_Dotted;
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Blue_Dotted;
 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Blue Background";

                transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Default Bluish Background";

                break;
        }

        if (Mevcut_BorderColors == Sayac_1)
        {
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(false);
        }

        if (Mevcut_BackgroundColors == Sayac_2)
        {
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.SetActive(false);
        }

        if (Border_Colors[Sayac_1] == 1)
        {
            Border_Fiyat[Sayac_1] = 0;

      transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(8).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.SetActive(false);
       transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(8).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;

            if (transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.activeInHierarchy)
                {
                 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(8).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Selected";
                }
              else
                 {
                 transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(8).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Select";
                }

        }
        else
        {
            Border_Fiyat[Sayac_1] = 200;

            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(8).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(8).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().alignment = TextAnchor.MiddleRight;
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(8).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "200";
        }

        if (BG_Colors[Sayac_2] == 1)
        {
            Background_Fiyat[Sayac_2] = 0;

            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;

            if (transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.activeInHierarchy)
                {
                    transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Selected";
                }
                else
                {
                    transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Select";
                }
        }
        else
        {
            Background_Fiyat[Sayac_2] = 250;

            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().alignment = TextAnchor.MiddleRight;
            transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "250";
        }


        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(8).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().fontSize = Screen.width / 26;
        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(8).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 32;

        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().fontSize = Screen.width / 26;
        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(0).gameObject.transform.GetChild(9).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = Screen.width / 32;

        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().fontSize = Screen.width / 32;
        transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.GetChild(10).gameObject.transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().fontSize = Screen.width / 36;
    }

    public void Buy_GridColors(int code)
    {
        if (OyuncuAyar.Para >= Grid_Fiyat[code])
        {
            OyuncuAyar.Para -= Grid_Fiyat[code];
            PlayerPrefs.SetInt("Para", OyuncuAyar.Para);

            Colors[code] = 1;
            PlayerPrefs.SetInt("Grid_Renk_" + code.ToString(), 1);

            Mevcut_GridColors = code;
            PlayerPrefs.SetInt("Mevcut_IzgaraRengi", Mevcut_GridColors);
        }
        else
        {
            ButonEksikPara();
        }
    }

    public void Buy_BorderColors()
    {
        if (OyuncuAyar.Para >= Border_Fiyat[Sayac_1])
        {
            OyuncuAyar.Para -= Border_Fiyat[Sayac_1];
            PlayerPrefs.SetInt("Para", OyuncuAyar.Para);

            Border_Colors[Sayac_1] = 1;
            PlayerPrefs.SetInt("Border_Renk_" + Sayac_1.ToString(), 1);

            Mevcut_BorderColors = Sayac_1;
            PlayerPrefs.SetInt("Mevcut_BorderRengi", Mevcut_BorderColors);
        }
        else
        {
            ButonEksikPara();
        }
    }

    public void Buy_BackgroundColors()
    {
        if (OyuncuAyar.Para >= Background_Fiyat[Sayac_2])
        {
            OyuncuAyar.Para -= Background_Fiyat[Sayac_2];
            PlayerPrefs.SetInt("Para", OyuncuAyar.Para);

            BG_Colors[Sayac_2] = 1;
            PlayerPrefs.SetInt("Bg_Renk_" + Sayac_2.ToString(), 1);

            Mevcut_BackgroundColors = Sayac_2;
            PlayerPrefs.SetInt("Mevcut_BackgroundRengi", Mevcut_BackgroundColors);

        }
        else
        {
            ButonEksikPara();
        }
    }

    public void Border_Buton(int SolSag)
    {
        if (SolSag == 0)
        {
            if (Sayac_1 > 0) { 
            Sayac_1 -= 1;
            }
        }
        else if (SolSag == 1)
        {
            if (Sayac_1 < 4)
            {
                Sayac_1 += 1;
            }           
        }
    }
    public void Background_Buton(int SolSag)
    {
        if (SolSag == 0)
        {
            if (Sayac_2 > 0)
            {
                Sayac_2 -= 1;
            }
        }
        else if (SolSag == 1)
        {
            if (Sayac_2 < 4)
            {
                Sayac_2 += 1;
            }
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
