using UnityEngine;
using System.Collections;

public class Food : MonoBehaviour {

	public GameObject prota;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D food){
		if (food.gameObject.tag == "Main Character") {

			prota.GetComponent<Stats> ().health = prota.GetComponent<Stats> ().health + 25;
			Destroy (this.gameObject);
		
		}
	
	
	}


}
