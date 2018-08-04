using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributeValue : MonoBehaviour {

    public int nilaiA;
    public int nilaiB;
    // nilai bisa diisi dengan range
    [Range(1, 5)]
    public int nilaiC;

	// Use this for initialization
	void Start () {
        int total = (nilaiA + nilaiB) * nilaiC;
        Debug.Log("Total " + total);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
