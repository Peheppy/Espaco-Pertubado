using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimentacao : MonoBehaviour
{
    [SerializeField]
    private float velocidade;
    [SerializeField]
    private float forcaPulo;
    private CapsuleCollider playerCollider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerCollider = GetComponent<CapsuleCollider>();
        ChecarChao();
    }
    private void ChecarChao()
    {
        Ray ray = new Ray(new Vector3(playerCollider.transform.position.x, playerCollider.transform.position.y), new Vector3(0,-1,0));
        RaycastHit hit;
        if(playerCollider.Raycast(ray, out hit, 20f))
        {
            Debug.Log("aaaaaa");

        }
    }
}
