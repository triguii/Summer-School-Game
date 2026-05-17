using UnityEngine;
using System.Collections;

public class PosFlecha : MonoBehaviour {

	public GameObject prota;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (prota.GetComponent<SpriteRenderer> ().flipX == true) {
			transform.position = prota.GetComponent<Transform>().position - new Vector3(1,-0.005f,0);


		}
		if (prota.GetComponent<SpriteRenderer> ().flipX == false) {
			transform.position = prota.GetComponent<Transform>().position + new Vector3(1,-0.005f,0);


		}
		
	}
}
