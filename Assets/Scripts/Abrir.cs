using UnityEngine;
using System.Collections;

public class Abrir : MonoBehaviour {
	public Sprite puertaAbierta;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D (Collider2D col){
		if (col.gameObject.tag == "Main Character") {
			
			if (Input.GetKeyDown (KeyCode.E)) {
				GetComponent<SpriteRenderer> ().sprite = puertaAbierta;
				Destroy (GetComponent<BoxCollider2D> ());
			}
		
		}
	
	}
}
