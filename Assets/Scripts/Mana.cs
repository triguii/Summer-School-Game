using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Mana : MonoBehaviour {
	public GameObject prota;
	public Image image;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		image.GetComponent<Image> ().fillAmount = prota.GetComponent<Stats> ().mana / prota.GetComponent<Stats> ().maxmana;
	}
}
