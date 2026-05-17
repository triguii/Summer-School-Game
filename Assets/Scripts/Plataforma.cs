using UnityEngine;
using System.Collections;

public class Plataforma : MonoBehaviour {

	public int dir = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (dir*0.03f, 0, 0);
	
	}
	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "Ground") {
			dir = dir * -1;
		
		}
	
	}
}
