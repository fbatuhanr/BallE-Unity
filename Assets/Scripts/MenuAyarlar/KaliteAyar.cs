using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KaliteAyar : MonoBehaviour {

    public Text QualityTxt, LowTxt, MediumTxt, HighTxt;
    public Image Low, Medium, High;
    public Color MaviRenk;

    int KaliteLevel;
	
    void Start()
    {

        KaliteLevel = PlayerPrefs.GetInt("KaliteDuzeyi", KaliteLevel);

        switch (KaliteLevel)
        {
            case 1:
                QualitySettings.SetQualityLevel(1);

                Low.color = MaviRenk;
                Medium.color = Color.white;
                High.color = Color.white;

                break;
            case 2:
                QualitySettings.SetQualityLevel(3);

                Low.color = Color.white;
                Medium.color = MaviRenk;
                High.color = Color.white;

                break;
            case 3:
                QualitySettings.SetQualityLevel(6);

                Low.color = Color.white;
                Medium.color = Color.white;
                High.color = MaviRenk;

                break;

            default:
                QualitySettings.SetQualityLevel(3);

                Low.color = Color.white;
                Medium.color = MaviRenk;
                High.color = Color.white;
                break;
        }
    }
	void Update () {

        KaliteLevel = PlayerPrefs.GetInt("KaliteDuzeyi", KaliteLevel);

        QualityTxt.fontSize = Screen.width / 17;

        LowTxt.fontSize = Screen.width / 35;
        MediumTxt.fontSize = Screen.width / 35;
        HighTxt.fontSize = Screen.width / 35;

        switch (KaliteLevel)
        {
            case 1:
                QualitySettings.SetQualityLevel(1);

                Low.color = MaviRenk;
                Medium.color = Color.white;
                High.color = Color.white;

                KaliteLevel = 1;
                PlayerPrefs.SetInt("KaliteDuzeyi", KaliteLevel);

                break;
            case 2:
                QualitySettings.SetQualityLevel(3);

                Low.color = Color.white;
                Medium.color = MaviRenk;
                High.color = Color.white;

                KaliteLevel = 2;
                PlayerPrefs.SetInt("KaliteDuzeyi", KaliteLevel);

                break;
            case 3:
                QualitySettings.SetQualityLevel(6);

                Low.color = Color.white;
                Medium.color = Color.white;
                High.color = MaviRenk;

                KaliteLevel = 3;
                PlayerPrefs.SetInt("KaliteDuzeyi", KaliteLevel);

                break;

            default:
                QualitySettings.SetQualityLevel(3);

                Low.color = Color.white;
                Medium.color = MaviRenk;
                High.color = Color.white;

                KaliteLevel = 2;
                PlayerPrefs.SetInt("KaliteDuzeyi", KaliteLevel);
                         
                break;
        }
    }

    public void LowQuality()
    {
        KaliteLevel = 1;
        PlayerPrefs.SetInt("KaliteDuzeyi", KaliteLevel);
    }
    public void MediumQuality()
    {
        KaliteLevel = 2;
        PlayerPrefs.SetInt("KaliteDuzeyi", KaliteLevel);
    }
    public void HighQuality()
    {
        KaliteLevel = 3;
        PlayerPrefs.SetInt("KaliteDuzeyi", KaliteLevel);
    }
}
