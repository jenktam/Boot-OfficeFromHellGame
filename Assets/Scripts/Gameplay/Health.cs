using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
	public int health = 3;
	public bool dieAtHealthZero = false;
	public Text healthText;
	public UnityEvent onHealthZero;
    public UnityEvent onHealthChange;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoseHealth();
        }
    }
    public void LoseHealth()
	{
		if (health <= 0)
			return;

		health--;

		if (health <= 0)
		{
			onHealthZero.Invoke();
			if (dieAtHealthZero)
				Destroy(gameObject);
		}

        onHealthChange.Invoke();
		if (healthText != null)
			healthText.text = health.ToString();
	}
}
