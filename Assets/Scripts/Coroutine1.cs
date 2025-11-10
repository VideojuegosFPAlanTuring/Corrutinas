using System.Collections;
using UnityEngine;

public class Coroutine1 : MonoBehaviour
{

    private void Start()
    {
        StartCoroutine(Hello());
    }

    IEnumerator Hello()
    {
        Debug.Log("Hello 1");
        yield return new WaitForSeconds(1f);
        Debug.Log("1 second later");
        yield return new WaitForSeconds(2f);
        Debug.Log("2 seconds later");        
    }
}
