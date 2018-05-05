using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hearts : MonoBehaviour {

	public float speed = 0.01f;
	int Heart = 0;
	public Text componenteHearts;

	// Use this for initialization
	void Start () {
	}


	void OnCollisionEnter2D(Collision2D coll){


		if (coll.collider.gameObject.tag == "Hearts")

			//Aumentamos la cantidad de moonedas del personaje

			Heart = Heart+ 1;

		// Actualizamos la cantidad de monedas en el componente Text
		componenteHearts.text =Heart.ToString();


	}
		
	}
	
	