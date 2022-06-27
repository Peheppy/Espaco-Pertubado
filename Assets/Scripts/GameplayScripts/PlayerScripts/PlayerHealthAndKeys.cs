using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthAndKeys : MonoBehaviour
{
    public FloatVariable playerHealth;
    public FloatVariable playerKeys;
    // Start is called before the first frame update
    private void Awake() 
    {
        playerHealth.value = 5f;   
        playerKeys.value = 0f; 
    }
    private void Update() 
    {
        ChangeToGameOver();    
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Enemy"))
        {
            playerHealth.value -= 1f;
            
        }
        else if(other.CompareTag("Water"))
        {
            playerHealth.value = 0f;
        }
        else if(other.CompareTag("Key"))
        {
            playerKeys.value += 1f;
            Destroy(other.gameObject);
        }
        else if(other.CompareTag("Credits") && KeysAcquired())
        {
            SceneManager.LoadScene("Credits_Scene");
        }
    }

    private void ChangeToGameOver()
    {
        if(playerHealth.value == 0f)
        {
            SceneManager.LoadScene("GameOver_Scene");
        }
    }
    private bool KeysAcquired()
    {
        if(playerKeys.value == 4f)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
