using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimentacao : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 5f;
    private Rigidbody playerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Moviment();
    }
    public void Moviment()
    {
        playerRigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * velocidade, 0f, Input.GetAxis("Vertical") * velocidade);
    }
}