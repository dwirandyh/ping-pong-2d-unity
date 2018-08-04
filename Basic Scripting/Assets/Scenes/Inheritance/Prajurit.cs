using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prajurit : Manusia {

	// Use this for initialization
	void Start () {
        Debug.Log("Seorang Prajurit Dpaat : ");
        Makan();
        Tidur();

        Menyerang();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Menyerang(){
        Debug.Log("Menyerang");
    }
}
