using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour {

	public int contador;
	public int vida;

	public Text score;
	public Text life;

	public GameObject perderPanel;
	bool perder = false;

	void Start () {
		contador = 0;
		vida = 3;
	}
	
	// Update is called once per frame
	void Update () {
		EscQuit();
		if((int) vida <= 0)
		{
			Time.timeScale = 0;
			life.text = "0";
			perderPanel.SetActive(true);
			perder = true;
		}
		if(perder == true && Input.GetKeyDown(KeyCode.Return))
		{
			SceneManager.LoadScene(0);
		}

	}

	public void EscQuit() {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene(0);
		}
	}

	public void AgregarScore()
	{
		contador++;
		score.text = contador.ToString();
	}

	public void QuitarVida()
	{
		vida--;
		life.text = vida.ToString();
	}

	public void SumarVida()
	{
		vida++;
		life.text = vida.ToString();
	}

}
