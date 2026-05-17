using UnityEngine;
using System.Collections;

public class ZonaMagia2 : MonoBehaviour {

	public GameObject prota;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (prota.GetComponent<SpriteRenderer> ().flipX == true) {
			transform.position = prota.transform.position - new Vector3 (1.5f, 0, 0);
		
		
		} else {
			transform.position = prota.transform.position + new Vector3 (1.5f, 0, 0);
		
		}
	
	}
}
