using UnityEngine;
using System.Collections;

public class CambioArma : MonoBehaviour {

	public bool EspadaB = true;
	public bool MagiaLL = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R) ) {
			EspadaB = !EspadaB;
			Debug.Log ("Has cambiado de arma");
		
		

		
		
	}
		if (Input.GetKeyDown (KeyCode.Q) ) {
			MagiaLL = !MagiaLL;
			Debug.Log ("Has cambiado de magia");

			}
	}}

