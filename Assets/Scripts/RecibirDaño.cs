using UnityEngine;
using System.Collections;

public class RecibirDaño : MonoBehaviour {

	public int DirKnockBack = -1;
	public int inv = 0;
	public bool tiempinv = false;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (tiempinv == true && inv < 70) {
			inv++;
		
		}
		if (inv >= 70) {
			tiempinv = false;
			inv = 0;
		
		}
		
		if (GetComponent<Stats> ().health <= 0f) {
			GetComponent <Animator> ().SetBool ("Muerte", true);
			Destroy (GetComponent<MOVER> ());


		}

			}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Pinchos") {
			GetComponent<Stats> ().health = 0;
		
		}
		if (col.gameObject.tag == "EnemySKELETON" && tiempinv == false) {
			if (col.gameObject.GetComponent<SpriteRenderer> ().flipX == true) {
				DirKnockBack = 1;

			
			} else {
				DirKnockBack = -1;
			
			}
			tiempinv = true;
			GetComponent<Rigidbody2D> ().AddForce (new Vector2(5*(DirKnockBack),6),ForceMode2D.Impulse);
			GetComponent<Stats> ().health =GetComponent<Stats> ().health - 15.0f;
		} 
		if (col.gameObject.tag == "Minotauro"&& tiempinv == false) {
			tiempinv = true;
			if (col.gameObject.GetComponent<BoxCollider2D> ().offset == new Vector2 (0.12f,0)) {
				DirKnockBack = 1;

			}else{
				DirKnockBack = -1;

			}


			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (4 * (DirKnockBack), 6), ForceMode2D.Impulse);
			GetComponent<Stats> ().health = GetComponent<Stats> ().health - 15.0f;
			col.gameObject.SetActive (false);
		}



	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "EspadaMinotauro") {
			tiempinv = true;
			if (col.gameObject.GetComponent<BoxCollider2D> ().offset == new Vector2 (0.12f, 0)) {
				DirKnockBack = 1;

			} else {
				DirKnockBack = -1;

			}


			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (7 * (DirKnockBack), 6), ForceMode2D.Impulse);
			GetComponent<Stats> ().health = GetComponent<Stats> ().health - 30.0f;
			col.gameObject.SetActive (false);
		}
	}


}
