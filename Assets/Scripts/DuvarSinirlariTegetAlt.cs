using UnityEngine;
using System.Collections;

public class DuvarSinirlariTegetAlt : MonoBehaviour {

	public static bool AltBGUstUsteBinisEngeli1,AltBGUstUsteBinisEngeli2;


	void OnTriggerStay(Collider DuvarTeget){
	
		if(DuvarTeget.gameObject.tag == "KarakterAlt1"){

			CharController2.AsagiGidisEngeli2 = true;
		}

		if(DuvarTeget.gameObject.tag == "KarakterAlt2"){

			CharController1.AsagiGidisEngeli1 = true;
		}

        if (DuvarTeget.gameObject.tag == "KarakterAlt3")
        {
            CharController3.AsagiGidisEngeli3 = true;
        }
    }
	void OnTriggerExit(Collider DuvarTegetAyrim){
		
		if(DuvarTegetAyrim.gameObject.tag == "KarakterAlt1"){

			CharController2.AsagiGidisEngeli2 = false;
		}

		if(DuvarTegetAyrim.gameObject.tag == "KarakterAlt2"){

			CharController1.AsagiGidisEngeli1 = false;
		}

        if (DuvarTegetAyrim.gameObject.tag == "KarakterAlt3")
        {
            CharController3.AsagiGidisEngeli3 = false;
        }
    }
}	
