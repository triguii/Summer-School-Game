using UnityEngine;
using System.Collections;

public class ParpadeoLus : MonoBehaviour {
	public Light FlashingLight;
	float RandoNum;
	// Use this for initialization
	void Start () {
		FlashingLight.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		RandoNum = Random.value;
		if (RandoNum <= 0.95f) {
			FlashingLight.enabled = true;
		
		
		
		} else {
		
			FlashingLight.enabled = false;
		
		}
	
	}
}
