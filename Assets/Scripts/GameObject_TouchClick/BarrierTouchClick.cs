using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Batuhan OZTURK 30.01.27

public class BarrierTouchClick : MonoBehaviour {

    public static bool WallCreator, WallBreaker;
    public static int Bariyer_Secenek;

    public static bool IptalEdici1, IptalEdici2, SecimIcinHareketEdildiMi;

    public static bool DahaOnceSecildiMi;

	void Start () {

        Bariyer_Secenek = 0;

        // Gosterge gameobject
        transform.GetChild(0).gameObject.SetActive(false);

        DahaOnceSecildiMi = false;

        WallCreator = false;
        WallBreaker = false;

        IptalEdici1 = false;
        IptalEdici2 = false;
        SecimIcinHareketEdildiMi = false;
    }
	
	void Update () {

        if (SecimIcinHareketEdildiMi)
        {
            Bariyer_Secenek = 0;

            SecimIcinHareketEdildiMi = false;
        }
        

        if (Bariyer_Secenek == 1) {

            if (WallCreator && !transform.GetChild(0).gameObject.GetComponent<BarrierTouch_Child>().WC_BarrierUstu_Spawn)
            {
                if (BarrierTouch_Child.GostergelerSaydamlasiyor)
                {
                    transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color -= new Color(0, 0, 0, Time.deltaTime);
                }
                else
                {
                    transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                }
                transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.SetActive(false);
                transform.GetChild(0).gameObject.SetActive(true);
                transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().enabled = true;
                IptalEdici1 = true;
            }
            else
            {
                transform.GetChild(0).gameObject.SetActive(false);
                IptalEdici2 = false;
            }
        }
        else if (Bariyer_Secenek == 2) {

            if (WallBreaker && transform.GetChild(0).gameObject.GetComponent<BarrierTouch_Child>().WC_BarrierUstu_Spawn)
            {
                if (BarrierTouch_Child.GostergelerSaydamlasiyor)
                {
                    transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color -= new Color(0, 0, 0, Time.deltaTime);
                }
                else
                {
                    transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                }
                DahaOnceSecildiMi = true;
                transform.GetChild(0).gameObject.SetActive(true);
                IptalEdici1 = true;
            }
            else
            {
                transform.GetChild(0).gameObject.SetActive(false);
                IptalEdici2 = false;
            }
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(false);
            WallBreaker = false;
            WallCreator = false;

            IptalEdici1 = false;
            IptalEdici2 = false;
        }

    }   
}
