using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private Transform playerTransform;

    private Transform enemyTransform;
    [SerializeField]
    private float enemyVelocity = 1f;
    // Start is called before the first frame update
    void Start()
    {
        enemyTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        GoToPlayer();
    }
    public void GoToPlayer()
    {
        float distance = Vector3.Distance(playerTransform.position, enemyTransform.position);
        if(distance < 20f)
        {
            enemyTransform.position = Vector3.MoveTowards(enemyTransform.position, playerTransform.position, enemyVelocity * Time.deltaTime);
            enemyTransform.LookAt(playerTransform);
            enemyTransform.Rotate(0f,-90,0f);
        }
    }
    
}
