using UnityEngine;
using System.Collections;

public class CaminarMinotauro : MonoBehaviour {
	public GameObject objetivo;
	public GameObject myPlayer;
	GameObject ultimoPunto; 
	public GameObject areaEspada;
	bool persiguiendo;
	int dir;
	public bool TocarCaja;
	public int vida = 200;
	public bool noTocar;
	public float vel = 0.05f;
	public bool Atacado ;

	// Use this for initialization
	void Start () {
		dir = 1;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (persiguiendo);
		if (vida<=0){
			myPlayer.GetComponent<Stats> ().exp += 75;
			Destroy (this.gameObject);
		}
		

		if (persiguiendo == true) {
			vel = 0.1f;
			if (myPlayer.transform.position.x < transform.position.x) {
				
				GetComponent<SpriteRenderer> ().flipX = true;
				dir = -1;
			} else {
				GetComponent<SpriteRenderer> ().flipX = false;
				dir = 1;
			}
		} else {
			vel = 0.05f;
		
		}
		if (Vector3.Distance (transform.position, myPlayer.transform.position) < 2.5f && myPlayer.GetComponent<RecibirDaño>().tiempinv == false) {
				GetComponent<Animator> ().SetBool ("Atacar", true);
				areaEspada.SetActive (true);
			
			} else {
				GetComponent<Animator> ().SetBool ("Atacar", false);
				areaEspada.SetActive (false);
			}

		
		if (GetComponent<SpriteRenderer> ().flipX == true) {
			GetComponent <BoxCollider2D> ().offset = new Vector2 (0.09f,0);
			areaEspada.GetComponent <BoxCollider2D> ().offset = new Vector2 (-0.17f,0);

		
		
		} else {
			GetComponent <BoxCollider2D> ().offset = new Vector2 (-0.07f,0);
			areaEspada.GetComponent <BoxCollider2D> ().offset = new Vector2 (0.12f,0);
		
		}
		
		transform.Translate (vel * dir, 0, 0);
	}
	void OnTriggerEnter2D (Collider2D obj){
		if (obj.tag == "Waypoint") {
			GetComponent<SpriteRenderer> ().flipX = !GetComponent<SpriteRenderer> ().flipX;
			dir = dir * -1;
			Debug.Log ("Hey");
			persiguiendo = false;

			}
		if (obj.gameObject.tag == "AreaEspada") {

			//GetComponent<Rigidbody2D> ().AddForce (new Vector2(5*(-prota.GetComponent<RecibirDaño>().DirKnockBack),2), ForceMode2D.Impulse);
			vida -=myPlayer.GetComponent<Stats> ().dañoEspada;
			obj.gameObject.SetActive (false);
			persiguiendo = true;

		} 
		if (obj.gameObject.tag == "AreaMagia") {

			//GetComponent<Rigidbody2D> ().AddForce (new Vector2(5*(-prota.GetComponent<RecibirDaño>().DirKnockBack),2), ForceMode2D.Impulse);
			vida -= myPlayer.GetComponent<Stats> ().dañoMagia;
			obj.gameObject.SetActive (false);
			persiguiendo = true;

		} 

		if (obj.gameObject.tag == "Flecha"  ) {

			//GetComponent<Rigidbody2D> ().AddForce (new Vector2(5*(-prota.GetComponent<RecibirDaño>().DirKnockBack),2), ForceMode2D.Impulse);
			vida -= myPlayer.GetComponent<Stats> ().dañoFlecha;
			Destroy (obj.gameObject);
			persiguiendo = true;


		} 
	}
		void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "Box" || col.gameObject.tag == "Wall"||col.gameObject.tag == "Puerta") {
			Debug.Log ("Colisionando");
				GetComponent<SpriteRenderer> ().flipX = !GetComponent<SpriteRenderer> ().flipX;
				dir = dir * -1;
				persiguiendo = false;
				

			}
		}

}