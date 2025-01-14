﻿using UnityEngine;

public class StopAllCollision : MonoBehaviour
{
	Collider2D[] colliders;

	void StopCollision()
	{
		colliders = FindObjectsOfType<Collider2D>();
		foreach (Collider2D col in colliders)
			col.enabled = false;
	}

	void StartCollision()
	{
		if (colliders.Length == 0)
			return;

		foreach (Collider2D col in colliders)
			col.enabled = true;
	}
}
