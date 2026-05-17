using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ataques : MonoBehaviour {
	public bool getSword ;
	public GameObject areaEspada;
	public GameObject Magia2;
	public GameObject areaMagia;
	public GameObject areaMagia2;
	public bool llamas;
	public bool magiadistancia;
	public GameObject flecha;
	public GameObject posflecha;
	public bool personajeGirado;
	public GameObject zonamagia2;
	public int Municion = 20;
	public Text TextoMun;





	//int tiempomagia = 0 ;

	float tiempoAtaque;
	float tiempoMagia;

	float cooldownAtaque;
	float cooldownAtaqueArco;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		TextoMun.text = "Arrows: "+Municion ;
		//Magia CC

		if (Time.time>=tiempoAtaque){
			areaEspada.SetActive (false);

		}
		if (Time.time >= tiempoMagia) {
			areaMagia.SetActive (false);
			GetComponent <Animator> ().SetBool ("Magia", false);
			llamas = false;
			GetComponent<Stats> ().mana += 0.1f;
		}


		if (Input.GetMouseButtonUp (1) && GetComponent<Stats> ().mana >= 25 && GetComponent<CambioArma> ().MagiaLL == true) {
			GetComponent <Animator> ().SetBool ("Magia", true);
			GetComponent<Stats> ().mana -= 25;
			llamas = true;

			areaMagia.SetActive (true);
			tiempoMagia = Time.time + 0.5f;
		

		} 

		//Magia a distancia
		if (Input.GetMouseButtonUp (1) && GetComponent<Stats> ().mana >= 30 && GetComponent<CambioArma> ().MagiaLL == false) {
			GetComponent <Animator> ().SetBool ("Magia", true);
			Instantiate (Magia2, zonamagia2.transform.position,zonamagia2.transform.rotation);
			GetComponent<Stats> ().mana -= 30;
			magiadistancia = true;
			areaMagia2.SetActive (true);


		} 


		//Espada
				
		if (Input.GetMouseButtonDown (0) && cooldownAtaque >= 30 && GetComponent<CambioArma>().EspadaB == true) {
			areaEspada.SetActive (true);
			tiempoAtaque = Time.time + 0.3f;
			GetComponent <Animator> ().SetBool ("Atacar Espada", true);
			cooldownAtaque = 0;


		} else  {
			cooldownAtaque ++;
			GetComponent <Animator> ().SetBool ("Atacar Espada", false);
		}

		//Arco
		if (Municion > 20){
			Municion = 20;

		}
		if (Municion < 0){
			Municion = 0;

		}

		if (Input.GetMouseButton (0) && cooldownAtaqueArco >= 60 && GetComponent<CambioArma> ().EspadaB == false && Municion > 0) {
			Municion--;
			GetComponent<Animator> ().SetBool ("Arco", true);
			cooldownAtaqueArco = 0;
			if (GetComponent<SpriteRenderer> ().flipX == true) {
				personajeGirado = true;

			} else {
				personajeGirado = false;

			}
			Instantiate (flecha, posflecha.transform.position, posflecha.transform.rotation);

		
		}
		else {
			cooldownAtaqueArco ++;
			GetComponent <Animator> ().SetBool ("Arco", false);

	}

		}





}
