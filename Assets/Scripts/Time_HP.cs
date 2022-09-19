using UnityEngine;
using System;
using UnityEngine.UI;
// Batuhan ÖZTÜRK 23.12.16

public class Time_HP : MonoBehaviour {

    int DakikaArtiBir;

    public Transform SaatCubuk;

    public Text UcYuz, IkiYuzYirmiBes, YuzElli, YetmisBes;
    public Text TimeLeft, HowMuchMoney, Info;

    // ANLIK
   public static int Hour, Day, Month, Year;

    void Update ()
    {
        Hour = PlayerPrefs.GetInt("xHour");
        Day = PlayerPrefs.GetInt("xDay");
        Month = PlayerPrefs.GetInt("xMonth");
        Year = PlayerPrefs.GetInt("xYear");

        if ((DateTime.Now.Year != Year) || (DateTime.Now.Month != Month) || (DateTime.Now.Day != Day) || (DateTime.Now.Hour != Hour))
        {
            if (OyuncuAyar.Can.ToString().Length == 1)
            {
                OyuncuAyar.Can += 5;
                PlayerPrefs.SetInt("Can", OyuncuAyar.Can);
            }

            Hour = DateTime.Now.Hour;
            Day = DateTime.Now.Day;
            Month = DateTime.Now.Month;
            Year = DateTime.Now.Year;

            PlayerPrefs.SetInt("xHour", Hour);
            PlayerPrefs.SetInt("xDay", Day);
            PlayerPrefs.SetInt("xMonth", Month);
            PlayerPrefs.SetInt("xYear", Year);
        }


        if (OyuncuAyar.Can.ToString().Length != 1)
        {
            SaatCubuk.localRotation = Quaternion.Euler(0, 0, 0);

            TimeLeft.text = "Your Health is Full";
            TimeLeft.fontSize = Screen.width / 29;

            UcYuz.text = "";
            IkiYuzYirmiBes.text = "";
            YuzElli.text = "";
            YetmisBes.text = "";

        }
        else
        {
            SaatCubuk.localRotation = Quaternion.Euler(0, 0, -((60 - DateTime.Now.Minute) * 6));

            TimeLeft.text = (60 - DateTime.Now.Minute).ToString();
            TimeLeft.fontSize = Screen.width / 18;

            UcYuz.text = "60";
            IkiYuzYirmiBes.text = "45";
            YuzElli.text = "30";
            YetmisBes.text = "15";
        }

        HowMuchMoney.text = "5";
        HowMuchMoney.fontSize = Screen.width / 18;

        Info.fontSize = Screen.width / 20;

        Info.text = "The Number of "+"  "+" has Reached Its Maximum Limit";

        UcYuz.fontSize = Screen.width / 32;
        IkiYuzYirmiBes.fontSize = Screen.width / 32;
        YuzElli.fontSize = Screen.width / 32;
        YetmisBes.fontSize = Screen.width / 32;
    }
}