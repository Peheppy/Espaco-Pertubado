using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CongratsControl : MonoBehaviour
{
    private void Update() 
    {
        StartCoroutine(GoToCreditsAfterDelay());
    }
    IEnumerator GoToCreditsAfterDelay ()
    {
        yield return new WaitForSecondsRealtime(7);
        SceneManager.LoadScene("Credits_Scene");
    }
}
