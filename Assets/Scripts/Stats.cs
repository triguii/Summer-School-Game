using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Stats : MonoBehaviour {
	public float health = 100f;
	public float maxhealth = 100f;
	public float exp = 0f;
	public float maxexp = 100f;
	public int dañoEspada = 20;
	public int dañoMagia = 40;
	public int dañoFlecha = 12;
	public float mana = 100f;
	public float maxmana = 100f;
	public int timedead = 0;
	public int Nivel = 1;
	public Text TextNivel;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		TextNivel.text = "Level : " + Nivel;

		if (health > maxhealth) {
			health = maxhealth;

		}
		if (mana > maxmana) {
			mana = maxmana;

		}if (mana < 0) {
			mana = 0;

		}
		if (health < 0) {
			health = 0;

		}
		if (exp >= maxexp) {
			
			maxhealth += 20;
			maxexp += 50;
			dañoEspada += 10;
			dañoMagia += 10;
			dañoFlecha += 10;
			health = maxhealth * 0.75f;
			maxmana += 20;
			mana = maxmana * 0.75f;
			Nivel++;
			exp = 0;


		}
		if (health <= 0) {
			timedead++;

			if (timedead == 100) {
				Destroy (this.gameObject);
				Dead ();
			
			
			}
		
		
		}
	
	}
	public void Dead(){
		SceneManager.LoadScene ("Menu");
	
	
	
	}
}
