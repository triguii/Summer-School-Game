using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Exp : MonoBehaviour {
	public GameObject prota;
	public Image image;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		image.GetComponent<Image> ().fillAmount = prota.GetComponent<Stats> ().exp / prota.GetComponent<Stats> ().maxexp;
	}
}
