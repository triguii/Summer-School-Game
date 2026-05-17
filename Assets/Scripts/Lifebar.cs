using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Lifebar : MonoBehaviour {
	public GameObject prota;
	public Image image;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		image.GetComponent<Image> ().fillAmount = prota.GetComponent<Stats> ().health / prota.GetComponent<Stats> ().maxhealth;
	
	}
}
