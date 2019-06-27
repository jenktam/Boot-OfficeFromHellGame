using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedOperations : MonoBehaviour
{
    public void DelayedSetActive(bool setActive)
    {
        StartCoroutine(SetActiveCoroutine(2,setActive));
    }

    private IEnumerator SetActiveCoroutine(float seconds, bool setActive)
    {
        yield return new WaitForSeconds(seconds);
        gameObject.SetActive(setActive);
    }

    public void DelayedLoadScene(SceneLoader sceneLoader)
    {
        StartCoroutine(LoadSceneCoroutine(sceneLoader));
    }

    private IEnumerator LoadSceneCoroutine(SceneLoader loader)
    {
        yield return new WaitForSeconds(2);
        loader.LoadScene();
    }

}
