using UnityEngine;
using System.Collections;

public class BolumBackgrounds : MonoBehaviour {

    public Sprite Blue_Dotted, Green_Dotted, Orange_Dotted, Red_Dotted, Yellow_Dotted;

    public Animator ArkaPlanAcilis, ArkaPlanKapanis;

    public Animator[] Sol;
    public Animator[] Sag;

    public static int Background_ColorCode;

    void Start()
    {
        ArkaPlanAcilis.enabled = true;
        ArkaPlanKapanis.enabled = false;
    }

    void Update() {

        switch (Background_ColorCode)
        {
            case 0:
                transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = Blue_Dotted;
                break;

            case 1:
                transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = Green_Dotted;
                break;

            case 2:
                transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = Orange_Dotted;
                break;
            case 3:
                transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = Red_Dotted;
                break;

            case 4:
                transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = Yellow_Dotted;
                break;

            default:
                transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = Blue_Dotted;
                break;
        }

        if (OyunMenu.BgUstveAltAnim)
        {
            ArkaPlanAcilis.enabled = false;
            ArkaPlanKapanis.enabled = true;

            Sol[0].enabled = true;
            Sol[1].enabled = true;
            Sol[2].enabled = true;
            Sol[3].enabled = true;
            Sol[4].enabled = true;
            Sol[5].enabled = true;
            Sol[6].enabled = true;
            Sol[7].enabled = true;

            Sag[0].enabled = true;
            Sag[1].enabled = true;
            Sag[2].enabled = true;
            Sag[3].enabled = true;
            Sag[4].enabled = true;
            Sag[5].enabled = true;
            Sag[6].enabled = true;
            Sag[7].enabled = true;

        }
        else
        {
            Sol[0].enabled = false;
            Sol[1].enabled = false;
            Sol[2].enabled = false;
            Sol[3].enabled = false;
            Sol[4].enabled = false;
            Sol[5].enabled = false;
            Sol[6].enabled = false;
            Sol[7].enabled = false;

            Sag[0].enabled = false;
            Sag[1].enabled = false;
            Sag[2].enabled = false;
            Sag[3].enabled = false;
            Sag[4].enabled = false;
            Sag[5].enabled = false;
            Sag[6].enabled = false;
            Sag[7].enabled = false;
        }

    }	
}
