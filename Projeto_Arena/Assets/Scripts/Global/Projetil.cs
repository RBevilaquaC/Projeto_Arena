using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    public float dano;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
