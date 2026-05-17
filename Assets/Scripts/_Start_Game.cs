using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class _Start_Game : MonoBehaviour {

	public Image Ventana;
	public Image Ventana2;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CargaNivel(){
		SceneManager.LoadScene ("Escena 1");
		


	}
	public void EncenderPantalla (){
		Ventana.gameObject.SetActive (true);


	}
	public void ApgarPantalla (){
		Ventana.gameObject.SetActive (false);


	}
	public void EncenderPantalla2(){
		Ventana2.gameObject.SetActive (true);

	}
	public void ApgarPantalla2 (){
		Ventana2.gameObject.SetActive (false);


	}
}
