using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaController : MonoBehaviour {

public GameScript gs;

	// Use this for initialization
	void Awake () {
		gs = GameObject.Find("GameManager").GetComponent<GameScript>();
	}

	void Update() {
		transform.Rotate (Vector3.forward);
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log("COLISIONE!!");
		if(col.gameObject.tag == "Player")
		{
			Debug.Log("exd");
			gs.SumarVida();
			Destroy(gameObject);
		}
	}

}
