using UnityEngine;
using System.Collections;

public class Salto : MonoBehaviour {

	public bool IsGrounded;

	// Use this for initialization
	void Start () {
	
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && IsGrounded) {

			GetComponent<Rigidbody2D> ().AddForce (new Vector2(0,10f),ForceMode2D.Impulse);



		}


	 

	}


	void OnCollisionStay2D(Collision2D col){
		if (col.gameObject.tag == "Ground"|| col.gameObject.tag == "Box" ||col.gameObject.tag == "Minotauro") {
			IsGrounded = true;
			Debug.Log ("Estoy en el suelo");
		
		} 


	}

	void OnCollisionExit2D(Collision2D col){
		if (col.gameObject.tag == "Ground" || col.gameObject.tag == "Box" ||col.gameObject.tag == "Minotauro" ) {
			IsGrounded = false;
			Debug.Log ("No estoy en el suelo");
	
		} 
	}

}
