using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float velocidade = 1;
    public float forcaPulo = 1;

    private Rigidbody2D rb;
    private bool facingRight = true;
    private bool noChao = false;


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        //groundCheck = gameObject.transform.Find("GroundCheck");
    }

    // Update is called once per frame
    void Update()
    {
        //noChao = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground");
        /*if(Input.GetButtonDown("Jump") /*&& noChao*//*)
        {
            jump = true;
            anim.SetTrigger("Pulou");
        }*/
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0, forcaPulo));

        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(h * velocidade, rb.velocity.y);
        
    }
}
