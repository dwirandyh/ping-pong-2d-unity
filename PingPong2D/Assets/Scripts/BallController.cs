using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

    int scoreP1;
    int scoreP2;

    public int force;
    Rigidbody2D rigid;

    Text scoreUIP1;
    Text scoreUIP2;

    GameObject panelSelesai;
    Text txtPemenang;

    AudioSource audio;
    public AudioClip hitSound;

    
	// Use this for initialization
	void Start () {

        scoreP1 = 0;
        scoreP2 = 0;

        // deklarasi text score
        scoreUIP1 = GameObject.Find("Score1").GetComponent<Text>();
        scoreUIP2 = GameObject.Find("Score2").GetComponent<Text>();

        // set arah bola ketika awal mulai -2 berarti ke kiri
        rigid = GetComponent<Rigidbody2D>();
        Vector2 arah = new Vector2(-2, 0).normalized;
        // memberikan tenaga agar bergerak
        rigid.AddForce(arah * force);

        // deklarasi panel
        panelSelesai = GameObject.Find("PanelSelesai");
        panelSelesai.SetActive(false);

        // deklarasi file suara
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// Mereset posisi bola agar di tengah kembali
    /// </summary>
    void ResetBall(){
        transform.localPosition = new Vector2(0, 0);
        rigid.velocity = new Vector2(0, 0);
    }

    /// <summary>
    /// Ketika terjadinya benturan dengan object lain
    /// </summary>
    /// <param name="collision">Collision.</param>
	private void OnCollisionEnter2D(Collision2D collision)
	{
        audio.PlayOneShot(hitSound);

        if (collision.gameObject.name == "TepiKanan"){
            ResetBall();
            scoreP1 += 1;
            Vector2 arah = new Vector2(2, 0).normalized;
            rigid.AddForce(arah * force);

            TampilkanScore();


            if (scoreP1 == 5){
                panelSelesai.SetActive(true);
                txtPemenang = GameObject.Find("TextPemenang").GetComponent<Text>();
                txtPemenang.text = "Player Kiri Menang";
                Destroy(gameObject);
                return;
            }
        }

        if (collision.gameObject.name == "TepiKiri"){
            ResetBall();
            scoreP2 += 1;
            Vector2 arah = new Vector2(-2, 0).normalized;
            rigid.AddForce(arah * force);

            TampilkanScore();

            if (scoreP2 == 5){
                panelSelesai.SetActive(true);
                txtPemenang = GameObject.Find("TextPemenang").GetComponent<Text>();
                txtPemenang.text = "Player Kanan Menang";
                Destroy(gameObject);
                return;
            }
        }

        if (collision.gameObject.name == "Pemukul1" || collision.gameObject.name == "Pemukul2"){
            float sudut = (transform.position.y - collision.transform.position.y) * 5f;
            Vector2 arah = new Vector2(rigid.velocity.x, sudut).normalized;
            rigid.velocity = new Vector2(0, 0);
            rigid.AddForce(arah * force * 2);
        }
	}

    void TampilkanScore(){
        scoreUIP1.text = scoreP1 + "";
        scoreUIP2.text = scoreP2 + "";
    }
}
