using System.Collections;
using UnityEngine;

public class Coroutine2 : MonoBehaviour
{
    private bool loaded = false;

    private void Start()
    {
        StartCoroutine(Play());
        StartCoroutine(Load());
    }

    IEnumerator Play()
    {
        Debug.Log("Waiting until loaded is true");
        //
        yield return new WaitUntil(()=> loaded);
        Debug.Log("Loaded completed");
        Debug.Log("Play Game");
    }

    IEnumerator Load()
    {
        yield return new WaitForSeconds(3f);
        loaded = true;
    }

}
