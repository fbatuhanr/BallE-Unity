using UnityEngine;
using System.Collections;

public class DuvarSinirlariTegetSol : MonoBehaviour {

	void OnTriggerStay(Collider DuvarTeget){

		if(DuvarTeget.gameObject.tag == "KarakterSag1"){

			CharController2.SolaGidisEngeli2 = true;
		}
		if(DuvarTeget.gameObject.tag == "KarakterSag2"){

			CharController1.SolaGidisEngeli1 = true;
		}
        if (DuvarTeget.gameObject.tag == "KarakterSol3")
        {
            CharController3.SolaGidisEngeli3 = true;
        }
    }
	void OnTriggerExit(Collider DuvarTegetAyrim){

		if(DuvarTegetAyrim.gameObject.tag == "KarakterSag1"){

			CharController2.SolaGidisEngeli2 = false;
		}

		if(DuvarTegetAyrim.gameObject.tag == "KarakterSag2"){

			CharController1.SolaGidisEngeli1 = false;
		}

        if (DuvarTegetAyrim.gameObject.tag == "KarakterSol3")
        {
            CharController3.SolaGidisEngeli3 = false;
        }
    }
}
