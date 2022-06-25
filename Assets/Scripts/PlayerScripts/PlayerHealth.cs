using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public FloatVariable playerHealth;
    // Start is called before the first frame update
    private void Awake() 
    {
        playerHealth.value = 5f;   
         
    }
    private void Update() 
    {
        ChangeToGameOver();    
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("EnemyAttack"))
        {
            playerHealth.value -= 1f;
            
        }
    }

    private void ChangeToGameOver()
    {
        if(playerHealth.value == 0f)
        {
            SceneManager.LoadScene("GameOver_Scene");
        }
    }
}
