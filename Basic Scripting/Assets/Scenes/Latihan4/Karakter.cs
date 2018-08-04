using UnityEngine;

public class Karakter : MonoBehaviour {

    private string charName;
    private int health;
    private int damage;

    public string Name{
        get{
            return charName;
        }
        set {
            charName = value;
        }
    }

    public int Health{
        get {
            return health;
        }
        set {
            health = value;
        }
    }

    public int Damage{
        get {
            return damage;
        }set {
            damage = value;
        }
    }

    public void MoveLeft(){
        Debug.Log("Gerak ke kiri");
    }

    public void MoveRight(){
        Debug.Log("Gerak ke kanan");
    }

    public void Jump(){
        Debug.Log("Lompat");
    }

    public void Attack(){
        Debug.Log("Pukul");
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
