using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

	// Use this for initialization
	public static int totalCoins = 0; 
	void Awake () {
		GetComponent<Collider2D>().isTrigger = true;
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D c2d) {
		if (c2d.CompareTag("Player")){
			totalCoins++;
			Debug.Log("Vc tem" + CoinScript.totalCoins + " coins");
			Destroy(gameObject);
		}
	}
}
