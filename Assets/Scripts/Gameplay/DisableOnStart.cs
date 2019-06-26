using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOnStart : MonoBehaviour
{

	// public string someThing;

	void Start()
	{
		gameObject.SetActive(false);
		// SaySomethingCool(someThing);
	}

	// void SaySomethingCool(string message) {
	// 	Debug.Log(message);
	// }
}
