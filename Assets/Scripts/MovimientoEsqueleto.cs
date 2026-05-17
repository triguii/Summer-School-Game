using UnityEngine;
using System.Collections;

public class MovimientoEsqueleto : MonoBehaviour {
	
	public int vida;
	bool choque ;
	float movE = 0.04f;
	int dir = -1;
	bool girado;
    //int DirKnockBack = -1;
	public GameObject prota;
	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
//		if (GetComponent <SpriteRenderer> ().flipX == false) {
//			DirKnockBack = 1;
//
//		} else { 
//			DirKnockBack = -1;
//
//		}

			transform.Translate (dir*movE, 0, 0);

		 


		if (vida<=0){
			prota.GetComponent<Stats> ().exp += 10;
			Destroy (this.gameObject);
		}
	
	}


	void OnCollisionStay2D(Collision2D col){
		if (col.gameObject.tag == "Box" || col.gameObject.tag == "Wall"|| col.gameObject.tag == "Main Character"|| col.gameObject.tag == "EnemySKELETON"|| col.gameObject.tag == "Puerta") {
			if (girado == false) {
				Debug.Log ("Estoy Chocando");
				GetComponent<SpriteRenderer> ().flipX = !GetComponent<SpriteRenderer> ().flipX;
				dir = dir * -1;
				girado = true;
			}
			//transform.Translate (-(movE), 0, 0);
			//choque = true;
		} 	
//

	}

	void OnCollisionExit2D(Collision2D col){
		if (col.gameObject.tag == "Box" || col.gameObject.tag == "Wall"|| col.gameObject.tag == "Main Character"|| col.gameObject.tag == "EnemySKELETON"|| col.gameObject.tag == "Puerta") {
			girado = false;
		} 	

	}


	void OnTriggerEnter2D(Collider2D obj){
		if (obj.gameObject.tag == "AreaEspada") {
			
			GetComponent<Rigidbody2D> ().AddForce (new Vector2(5*(-prota.GetComponent<RecibirDaño>().DirKnockBack),2), ForceMode2D.Impulse);
			vida -= prota.GetComponent<Stats> ().dañoEspada;
			obj.gameObject.SetActive (false);
		} 
		if (obj.gameObject.tag == "AreaMagia") {
			
			GetComponent<Rigidbody2D> ().AddForce (new Vector2(5*(-prota.GetComponent<RecibirDaño>().DirKnockBack),2), ForceMode2D.Impulse);
			vida -= prota.GetComponent<Stats> ().dañoMagia;
			obj.gameObject.SetActive (false);
		} 
		if (obj.gameObject.tag == "Flecha"  ) {

			GetComponent<Rigidbody2D> ().AddForce (new Vector2(5*(-prota.GetComponent<RecibirDaño>().DirKnockBack),2), ForceMode2D.Impulse);
			vida -= prota.GetComponent<Stats> ().dañoFlecha;
			Destroy (obj.gameObject);

		} 

	}

}
