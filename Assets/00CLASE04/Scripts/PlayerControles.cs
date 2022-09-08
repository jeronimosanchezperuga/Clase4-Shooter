using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControles : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocidadMovimiento;
    public float fuerzaSalto;
    public bool estaEnElPiso;
    public LayerMask layerMask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movX = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(movX * velocidadMovimiento,rb.velocity.y);

        if (movX < 0)
        {
            transform.localScale = new Vector3(-1,1,1);
        }
        if (movX>0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.W) && estaEnElPiso)
        {
            rb.AddForce(Vector2.up * fuerzaSalto,ForceMode2D.Impulse);
        }

        estaEnElPiso = Physics2D.OverlapCircle(transform.position,0.3f,layerMask);

    }
}
