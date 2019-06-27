using UnityEngine;

public class MemoryCard : MonoBehaviour
{
	public int value;
	public MemoryManager manager;

	Collider2D collider;
	GameObject cardImage;

    void Start()
    {
		collider = GetComponent<Collider2D>();
		cardImage = GetComponentInChildren<SpriteRenderer>().gameObject;
    }

	void OnMouseDown()
	{
		collider.enabled = false;
		cardImage.SetActive(true);
	}

	public void Flip()
	{
		cardImage.SetActive(false);
		collider.enabled = true;
	}
}
