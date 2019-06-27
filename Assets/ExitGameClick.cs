using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGameClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("exit game!");
        Application.Quit(); // this quits the game.
    }
}
