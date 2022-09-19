using UnityEngine;
using System.Collections;

public class DuvarSinirlariTegetUst : MonoBehaviour {
	
	void OnTriggerStay(Collider DuvarTeget){

		if(DuvarTeget.gameObject.tag == "KarakterUst1"){

			CharController2.YukariGidisEngeli2 = true;
		}

		if(DuvarTeget.gameObject.tag == "KarakterUst2"){

			CharController1.YukariGidisEngeli1 = true;
		}

        if (DuvarTeget.gameObject.tag == "KarakterUst3")
        {
            CharController3.YukariGidisEngeli3 = true;
        }
    }
	void OnTriggerExit(Collider DuvarTegetAyrim){

		if(DuvarTegetAyrim.gameObject.tag == "KarakterUst1"){

			CharController2.YukariGidisEngeli2 = false;
		}

		if(DuvarTegetAyrim.gameObject.tag == "KarakterUst2"){

			CharController1.YukariGidisEngeli1 = false;
		}

        if (DuvarTegetAyrim.gameObject.tag == "KarakterUst3")
        {
            CharController3.YukariGidisEngeli3 = false;
        }
    }
}
