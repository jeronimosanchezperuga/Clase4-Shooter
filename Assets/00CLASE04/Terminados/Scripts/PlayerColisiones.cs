using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColisiones : MonoBehaviour
{

    public GameObject arma;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ActivarArma"))
        {
            arma.SetActive(true);
            Destroy(collision.gameObject);
        }
    }
}
