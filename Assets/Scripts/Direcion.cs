using UnityEngine;
using System.Collections;

public class Direcion : MonoBehaviour {
	public GameObject protagonista;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (protagonista.GetComponent<SpriteRenderer> ().flipX == true) {
			GetComponent<BoxCollider2D> ().offset = new Vector2 (-4.5f, 0);
		
		
		
		} else {
			GetComponent<BoxCollider2D> ().offset = new Vector2 (1, 0);
		
		}
	}
}
