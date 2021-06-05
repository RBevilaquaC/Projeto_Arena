using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public Transform pivot;
    public Transform bocaDoCano;
    public GameObject projetil;
    public int dano;
    public float forcaProjetil;
    void Start()
    {
        
    }
    
    void Update()
    {
        UpdateRotacao();
        CheckGatilho();
    }

    private void CheckGatilho()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 atualPos = transform.position;
            Vector2 direction = (mousePos - atualPos).normalized;
            float angulo = AnguloEntreDoisPontos(atualPos, mousePos);
            GameObject disparo = Instantiate(projetil, bocaDoCano.transform.position
                                            ,Quaternion.Euler (new Vector3(0f,0f,angulo)));
            disparo.GetComponent<Rigidbody2D>().AddForce(direction*forcaProjetil);
            disparo.GetComponent<Projetil>().dano = dano;
        }
    }
    
    private void UpdateRotacao()
    {
        Vector2 atualPos = Camera.main.WorldToViewportPoint (transform.position);
        Vector2 mousePos = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);
        float angulo = AnguloEntreDoisPontos(atualPos, mousePos);
        pivot.transform.rotation =  Quaternion.Euler (new Vector3(0f,0f,angulo));
    }
    private float AnguloEntreDoisPontos(Vector3 a, Vector3 b) {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
    
    
}
