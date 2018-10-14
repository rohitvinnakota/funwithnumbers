using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour 
{
	public void GoToLevel(string levelName)
	{
		Application.LoadLevel(levelName);
	}

	public void Quit()
	{
		Application.Quit();
	}
}
