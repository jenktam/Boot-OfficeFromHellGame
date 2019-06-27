using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthConfiguration : MonoBehaviour
{
    public List<HeartConfiguration> hearts;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setHearts(Health health)
    {

        for (int j = 0; j < hearts.Count; j++)
        {
            Debug.Log($"health.health {health.health}");
            Debug.Log($"j={j*2}");
            if (health.health >= (j * 2)+2)
            {
                hearts[j].heartType = HeartType.fullHeart; 
            } else if(health.health <= (j)*2)
            {
                hearts[j].heartType = HeartType.emptyHeart;
            }
            else
            {
                hearts[j].heartType = HeartType.halfHeart;
            }
        }
    }
}
