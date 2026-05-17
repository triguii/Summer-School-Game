using UnityEngine;
using System.Collections;

public class Flecha : MonoBehaviour {
	public GameObject prota;
	int dir;
	public int tiempovida = 0;
	// Use this for initialization
	void Start () {
		dir = 1;
	}

	// Update is called once per frame
	void Update () {
		tiempovida++;
		if (tiempovida >= 300) {
			Destroy (this.gameObject);
		
		}
		
		if (GameObject.Find("Prota").GetComponent<Ataques>().personajeGirado == true) {
			Debug.Log ("Mirando a la Izwuierda");
			GetComponent<SpriteRenderer> ().flipX = true;

			dir = -1;

		} else {
			Debug.Log ("Mirando a la Derecha");
			GetComponent<SpriteRenderer> ().flipX = false;
			dir = 1;

		}
		Debug.Log (dir);

		transform.Translate (0.25f*dir, 0, 0);

	}

	void OnCollisionEnter2D(Collision2D Flecha){
		if (Flecha.gameObject.tag != "Enemigo" || Flecha.gameObject.tag != "Main Character") {
		
			Destroy (this.gameObject);	
		}

	
	
	}
}
