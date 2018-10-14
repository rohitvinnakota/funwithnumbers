using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour 
{
	[SerializeField]
	Boundary boundaryPrefab = null;

	[SerializeField]
	Panel panelPrefab = null;

	[SerializeField]
	Vector3 position = Vector3.zero; 

	// Use this for initialization
	void Start () 
	{
		Instantiate(boundaryPrefab, position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
