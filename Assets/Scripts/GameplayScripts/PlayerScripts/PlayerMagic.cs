using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMagic : MonoBehaviour
{
    public FloatVariable PlayerMP;
    [SerializeField]
    private GameObject bomb;
    private Transform playerTransform;
    private bool updateDelay;
    private bool delayIsActive;
    // Start is called before the first frame update
    private void Awake() 
    {
        PlayerMP.value = 4f;    
    }
    private void Start() 
    {
        updateDelay = false;
        delayIsActive = false;
        playerTransform = GetComponent<Transform>();    
    }
    // Update is called once per frame
    void Update()
    {
        CastAttack();
        if(PlayerMP.value < 4f && !updateDelay)
        {
            updateDelay = true;
            StartCoroutine(GenerateMana());
        }
    }
    public void CastAttack ()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            if(PlayerMP.value > 0f && !delayIsActive)
            {
                delayIsActive = true;
                PlayerMP.value -= 1f;
                Instantiate(bomb, playerTransform.position+(playerTransform.forward*2), Quaternion.identity);
                StartCoroutine(Delay());
            }

        }
    }
    IEnumerator Delay()
    {
        yield return new WaitForSecondsRealtime(3);
        delayIsActive = false;
    }
    IEnumerator GenerateMana()
    {
        yield return new WaitForSecondsRealtime(10);
        PlayerMP.value += 1f;
        updateDelay = false;
    }
}
