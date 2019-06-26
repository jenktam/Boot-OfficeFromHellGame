using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public bool isProjectile = false;
    public int direction = 1;
	public Vector2 speedPerAxis;
	public bool moveRelativeToRotation = false;

	Space mode;

	void Update()
    {
		if (moveRelativeToRotation == true)
			mode = Space.Self;
		else
			mode = Space.World;

        if (isProjectile) transform.rotation = Quaternion.Euler(0, 0, direction == 1 ? 90 : 270);

		if(moveRelativeToRotation == true)
			transform.Translate(speedPerAxis * Time.deltaTime, mode);
	}
}
