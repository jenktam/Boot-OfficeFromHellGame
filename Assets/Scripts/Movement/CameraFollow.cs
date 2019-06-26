﻿using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform target;

	Vector3 offset;

    void Start()
    {
		offset = transform.position - target.position;
    }

    void LateUpdate()
    {
		transform.position = target.position + offset;
    }
}
