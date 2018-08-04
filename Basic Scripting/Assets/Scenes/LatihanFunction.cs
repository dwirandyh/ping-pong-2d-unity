using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatihanFunction : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int c = Jumlah(60, 40);
        Debug.Log("Hasil Jumlah a dan b adalah = " + c);
	}

    /// <summary>
    /// Jumlah the specified a and b.
    /// </summary>
    /// <returns>The jumlah.</returns>
    /// <param name="a">The alpha component.</param>
    /// <param name="b">The blue component.</param>
    int Jumlah(int a, int b){
        return a + b;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
