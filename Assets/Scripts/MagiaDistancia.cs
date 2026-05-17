using UnityEngine;
using System.Collections;

public class MagiaDistancia : MonoBehaviour {

	int dirMagia = 1;
	bool MagiaActiva;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (GameObject.Find("Prota").GetComponent<SpriteRenderer> ().flipX == true) {
			GetComponent<SpriteRenderer> ().flipX = true;


		
		}else{
			GetComponent<SpriteRenderer>().flipX = false;
		}
		if (GameObject.Find("Prota").GetComponent<Ataques>().magiadistancia == true) {
			GetComponent<Animator> ().SetBool ("Magia ", true);

		} else {
			GetComponent<Animator> ().SetBool ("Magia ", false);

		}

		if (GetComponent<SpriteRenderer> ().flipX == true && GameObject.Find("Prota").GetComponent<Ataques>().magiadistancia == true) {
			dirMagia = -1;

		} else if (GameObject.Find("Prota").GetComponent<Ataques>().magiadistancia == true) {
			dirMagia = 1;
		}

		transform.Translate (0.1f*dirMagia, 0, 0);





	
	}
	void OnCollisionEnter2D(Collision2D magia){
		if (magia.gameObject.tag != "AreaEspada" && magia.gameObject.tag != "AreaMagia" &&magia.gameObject.tag != "Ground" ) {
			Destroy (this.gameObject);
			MagiaActiva = false;
		}

	}


}
