using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class MoveWithInput : MonoBehaviour
{
    public int lastHorizontalMovement = 0;
	public float speed = 5f;

	public KeyCode leftButton = KeyCode.A;
	public KeyCode rightButton = KeyCode.D;
	public KeyCode upButton = KeyCode.W;
	public KeyCode downButton = KeyCode.S;

	void Update()
    {
		float amount = speed * Time.deltaTime;

		if (Input.GetKey(leftButton))
        {
            transform.Translate(-amount, 0f, 0f, Space.World);
            lastHorizontalMovement = -1;
        }
		if (Input.GetKey(rightButton))
        {
            transform.Translate(amount, 0f, 0f, Space.World);
            lastHorizontalMovement = 1;
        }
		if (Input.GetKey(upButton))
			transform.Translate(0f, amount, 0f, Space.World);

		if (Input.GetKey(downButton))
			transform.Translate(0f, -amount, 0f, Space.World);
	}
}


