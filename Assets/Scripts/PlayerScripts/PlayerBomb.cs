using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBomb : MonoBehaviour
{
    private BoxCollider explotionCollider;
    
    void Start()
    {
        explotionCollider = GetComponent<BoxCollider>();
        StartCoroutine(StartExplotion());    
    }

    IEnumerator StartExplotion()
    {
        yield return new WaitForSecondsRealtime(4);
        explotionCollider.enabled = true;
        StartCoroutine(SafetyDelay());
    }
    IEnumerator SafetyDelay ()
    {
        yield return new WaitForSecondsRealtime(2);
        Destroy(gameObject);
    }
}
