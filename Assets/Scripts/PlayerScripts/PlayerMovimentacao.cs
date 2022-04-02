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
        if (Input.GetAxis("Vertical") > 0f)
        {
            //// para cima
            if (Input.GetAxis("Horizontal") > 0f)
            {
                // para cima direita
                playerRigidbody.velocity = new Vector3(velocidade, 0f, velocidade);
            }
            else if (Input.GetAxis("Horizontal") < 0f)
            {
                // para cima esquerda
                playerRigidbody.velocity = new Vector3(-velocidade, 0f, velocidade);
            }
            else
            {
                playerRigidbody.velocity = new Vector3(0f, 0f, velocidade);
            }
        }
        else if (Input.GetAxis("Vertical") < 0f)
        {
            ////para baixo
            if (Input.GetAxis("Horizontal") > 0f)
            {
                // para baixo direita
                playerRigidbody.velocity = new Vector3(velocidade, 0f, -velocidade);
            }
            else if (Input.GetAxis("Horizontal") < 0f)
            {
                // para baixo esquerda
                playerRigidbody.velocity = new Vector3(-velocidade, 0f, -velocidade);
            }
            else
            {
                playerRigidbody.velocity = new Vector3(0f, 0f, -velocidade);
            }
        }
        else
        {
            playerRigidbody.velocity = new Vector3(0f, 0f, 0f);
        }
        if (Input.GetAxis("Horizontal") > 0f)
        {
            //// para direita
            if (Input.GetAxis("Vertical") > 0f)
            {
                //para direita cima
                playerRigidbody.velocity = new Vector3(velocidade, 0f, velocidade);
            }
            else if (Input.GetAxis("Vertical") < 0f)
            {
                // para direita baixo
                playerRigidbody.velocity = new Vector3(velocidade, 0f, -velocidade);
            }
            else
            {
                playerRigidbody.velocity = new Vector3(velocidade, 0f, 0f);
            }
        }
        else if (Input.GetAxis("Horizontal") < 0f)
        {
            //// para esquerda
            if (Input.GetAxis("Vertical") > 0f)
            {
                //para esquerda cima
                playerRigidbody.velocity = new Vector3(-velocidade, 0f, velocidade);
            }
            else if (Input.GetAxis("Vertical") < 0f)
            {
                // para esquerda baixo
                playerRigidbody.velocity = new Vector3(-velocidade, 0f, -velocidade);
            }
            else
            {
                playerRigidbody.velocity = new Vector3(-velocidade, 0f, 0f);
            }
        }
        else
        {
            playerRigidbody.velocity = new Vector3(0f, 0f, 0f);
        }
    }

}