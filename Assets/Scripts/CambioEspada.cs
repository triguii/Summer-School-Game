using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CambioEspada : MonoBehaviour {

	public GameObject prota;
	public Sprite Espada;
	public Sprite Arco;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (prota.GetComponent<CambioArma> ().EspadaB == true) {
			this.transform.GetComponent<UnityEngine.UI.Image> ().sprite = Espada;
		
		} else {
		
			this.transform.GetComponent<UnityEngine.UI.Image> ().sprite = Arco;
		}
	
	}
}
