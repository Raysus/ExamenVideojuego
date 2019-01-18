using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitavidaController : MonoBehaviour {

public GameScript gs;

	// Use this for initialization
	void Awake () {
		gs = GameObject.Find("GameManager").GetComponent<GameScript>();
	}

	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log("COLISIONE!!");
		if(col.gameObject.tag == "Player")
		{
			Debug.Log("exd");
			gs.QuitarVida();
			Destroy(gameObject);
		}
	}

}
