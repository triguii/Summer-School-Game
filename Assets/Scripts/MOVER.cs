using UnityEngine;
using System.Collections;

public class MOVER : MonoBehaviour {
	public GameObject areaEspada;

	// Use this for initialization
	void Start () {
	
	}

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			if (GetComponent <SpriteRenderer> ().flipX == true) {
				GetComponent <SpriteRenderer> ().flipX = false;
				GetComponent <PolygonCollider2D> ().offset =  new Vector2 (0,0);
				areaEspada.GetComponent <BoxCollider2D> ().offset =  new Vector2 (0f,0);
						
			}
			GetComponent <Animator> ().SetBool ("run", true);
			transform.Translate (0.04f, 0, 0);

		} 

		else if (Input.GetKey (KeyCode.A)) {
			if (GetComponent <SpriteRenderer> ().flipX == false) {
				GetComponent <SpriteRenderer> ().flipX = true;
				GetComponent <PolygonCollider2D> ().offset =  new Vector2 (0.5f,0);
				areaEspada.GetComponent <BoxCollider2D> ().offset =  new Vector2 (-4.0f,0);
			}
			GetComponent <Animator> ().SetBool ("run", true);
			transform.Translate (-0.04f, 0, 0);

		} else {
			GetComponent <Animator> ().SetBool ("run", false);
		
		}

	



	}







}
