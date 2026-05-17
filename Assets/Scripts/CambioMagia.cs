using UnityEngine;
using System.Collections;

public class CambioMagia : MonoBehaviour {
	public GameObject prota;
	public Sprite Fuego;
	public Sprite Aro;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (prota.GetComponent<CambioArma> ().MagiaLL == true) {
			this.transform.GetComponent<UnityEngine.UI.Image> ().sprite = Fuego;

		} else {

			this.transform.GetComponent<UnityEngine.UI.Image> ().sprite = Aro;
		}
	}
}
