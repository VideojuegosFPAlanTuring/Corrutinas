using System.Collections;
using UnityEngine;

public class Coroutine3 : MonoBehaviour
{
    private Coroutine activeCoroutine;

    private void Start()
    {
        activeCoroutine = StartCoroutine(Count());
        Invoke(nameof(StopCounting), 3f);
    }

    IEnumerator Count()
    {
        int i = 0;
        while (true)
        {
            Debug.Log($"Contador:{i++}");
            yield return new WaitForSeconds(1f);
        }
    }

    private void StopCounting()
    {        
        StopCoroutine(activeCoroutine);
        Debug.Log("Coroutine stopped");
    }


}
