using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Karakter player1;

	// Use this for initialization
	void Start () {
        player1 = new Karakter();
        player1.Name = "Randy";
        player1.Health = 100;
        player1.Damage = 50;

        Debug.Log("Name : " + player1.name + ", Health: " + player1.Health + ", Damage: " + player1.Damage);

        player1.Jump();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
