using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

	public GameObject gameMenu;

	void Start ()
	{
		gameMenu.SetActive (false); 
	}

	public void displayGameMenu()
	{
		if (gameMenu.activeSelf == false) {
			gameMenu.SetActive (true);
		} 
		else 
		{
			gameMenu.SetActive (false);
		}
	}
}
