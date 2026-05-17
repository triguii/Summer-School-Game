using UnityEngine;
using System.Collections;

public class Flechascojer : MonoBehaviour {

	public GameObject prota;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D flechas){
		if (flechas.gameObject.tag == "Main Character") {

			prota.GetComponent<Ataques> ().Municion = prota.GetComponent<Ataques> ().Municion + 5;
			Destroy (this.gameObject);

		}


	}
}
