using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monedasss : MonoBehaviour {

    public float speed = 0.01f;
    int Coin = 0;
	public Text componCoin;

// Use this for initialization
void Start () {
}


void OnCollisionEnter2D(Collision2D coll){


	if (coll.collider.gameObject.tag == "Coins")

		//Aumentamos la cantidad de moonedas del personaje

			Coin = Coin + 1;

	// Actualizamos la cantidad de monedas en el componente Text
		componCoin.text =Coin.ToString();


}

}
