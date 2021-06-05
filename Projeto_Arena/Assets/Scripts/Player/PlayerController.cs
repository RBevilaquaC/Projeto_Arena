using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float velocidade = 1;
    public float forcaPulo = 1;

    private Rigidbody2D rb;
    private bool noChao = false;


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        Mover();
        Pular();
    }


    private void Mover()
    {
        float h = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(h * velocidade, rb.velocity.y);
    }
    private void Pular()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0, forcaPulo));

        }
    }
    
}
