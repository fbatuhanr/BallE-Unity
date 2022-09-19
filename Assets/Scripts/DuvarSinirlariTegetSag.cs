	using UnityEngine;
using System.Collections;

public class DuvarSinirlariTegetSag : MonoBehaviour {


	void OnTriggerStay(Collider DuvarTeget){

		if(DuvarTeget.gameObject.tag == "KarakterSol1"){

			CharController2.SagaGidisEngeli2 = true;
		}

		if(DuvarTeget.gameObject.tag == "KarakterSol2"){

			CharController1.SagaGidisEngeli1 = true;
		}

        if (DuvarTeget.gameObject.tag == "KarakterSag3")
        {
            CharController3.SagaGidisEngeli3 = true;
        }
    }
	void OnTriggerExit(Collider DuvarTegetAyrim){

		if(DuvarTegetAyrim.gameObject.tag == "KarakterSol1"){

			CharController2.SagaGidisEngeli2 = false;
		}

		if(DuvarTegetAyrim.gameObject.tag == "KarakterSol2"){

			CharController1.SagaGidisEngeli1 = false;
		}

        if (DuvarTegetAyrim.gameObject.tag == "KarakterSag3")
        {
            CharController3.SagaGidisEngeli3 = false;
        }
    }
}
