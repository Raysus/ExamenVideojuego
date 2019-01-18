using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	public GameObject menu;
	public GameObject credits;

	public void MainMenu()
	{
		menu.SetActive(true);
		credits.SetActive(false);
	}

	public void CreditsMenu()
	{
		menu.SetActive(false);
		credits.SetActive(true);
	}
	public void Play ()
	{
		SceneManager.LoadScene(1);
	}

	public void Quit ()
	{
		Application.Quit();
		Debug.Log("Se ha cerrado el juego");
	}
}