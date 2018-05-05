using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour {

	public float speed = 0.01f;
	int Stars = 0;
	public Text componeteCoins;

	public void ClickEnElBoton() {
		print ("El usuario hizo clic en el boton");
		this.gameObject.GetComponent<Rigidbody2D>  ().AddForce (Vector2.up  * 5,ForceMode2D.Impulse);
	}

	// Use this for initialization
	void Start () {
		
	}
		
	void OnCollisionEnter2D(Collision2D coll){
		

		if (coll.collider.gameObject.tag == "Stars")

		//Aumentamos la cantidad de moonedas del personaje

			Stars = Stars + 1;
		
			// Actualizamos la cantidad de monedas en el componente Text
		componeteCoins.text =Stars.ToString();



	}
	
	// Update is called once per frame
	void Update () {
		
	//movimiento a la derecha
		if(Input.GetKey(KeyCode.RightArrow)){
			this.transform.Translate (speed,0,0);
		}

	//movimiento a la Izquierda
		if(Input.GetKey(KeyCode.LeftArrow)){
			this.transform.Translate (-speed,0,0);

		}

		//si la tecla barra espaciadora se presiona
		if(Input.GetKeyDown(KeyCode.Space)){

			//Le agrego una fuerza hacia arriba

			this.gameObject.GetComponent<Rigidbody2D>  ().AddForce (Vector2.up  * 5,ForceMode2D.Impulse);
		}
	}
}

