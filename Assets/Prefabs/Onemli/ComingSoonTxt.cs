using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ComingSoonTxt : MonoBehaviour {

    Text comingsoon;

	void Start () {
        comingsoon = GetComponent<Text>();
    }
	
	void Update () {
        comingsoon.fontSize = Screen.width / 20;
    }
}
