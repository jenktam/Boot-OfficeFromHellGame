using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthConfiguration : MonoBehaviour
{
    public List<GameObject> listOfHearts;

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
        for(int i = 0; i <= listOfHearts.Count; i++)
        {
            listOfHearts[i].SetActive((i < health.health));
        }
    }
}
