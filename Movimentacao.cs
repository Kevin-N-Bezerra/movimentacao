using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movimentacao : MonoBehaviour
{
    Vector3 movimentacao;
    // Start is called before the first frame update
    void Start()
    {
        movimentacao = new Vector3(8.535f, 3.35f, 0.6207848f);
        transform.position = movimentacao;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            movimentacao.x = 0.05f;
            movimentacao.y = 0f;
            movimentacao.z = 0f;
            transform.Translate(movimentacao);

        }
        if (Input.GetKey(KeyCode.A))
        {
            movimentacao.x = -0.05f;
            movimentacao.y = 0f;
            movimentacao.z = 0f;
            transform.Translate(movimentacao);

        }
        if (Input.GetKey(KeyCode.W))
        {
            movimentacao.x = 0f;
            movimentacao.y = 0f;
            movimentacao.z = 0.05f;
            transform.Translate(movimentacao);

        }
        if (Input.GetKey(KeyCode.S)) 
        {
            movimentacao.x = 0f;
            movimentacao.y = 0f;
            movimentacao.z = -0.05f;
            transform.Translate(movimentacao);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            movimentacao.x = 0f;
            movimentacao.y = 0.05f;
            movimentacao.z = 0f;
            transform.Translate(movimentacao);
        }
        

    }
}
