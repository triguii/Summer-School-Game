using UnityEngine;
using System.Collections;

public class LlAMAS : MonoBehaviour {
	public GameObject Prota;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<SpriteRenderer> ().flipY = Prota.GetComponent<SpriteRenderer> ().flipX;
		if (Prota.GetComponent<Ataques>().llamas == true) {
			GetComponent<Animator> ().SetBool ("LanzarMagiaFuego", true);

		} else {
			GetComponent<Animator> ().SetBool ("LanzarMagiaFuego", false);

		}

		if (GetComponent<SpriteRenderer> ().flipY == false) {
			transform.position = Prota.transform.position + new Vector3(0.79f,-0.5f,0);	
		} else {
			transform.position = Prota.transform.position - new Vector3(0.79f,0.5f,0);	
		}

	
	
	}
}
