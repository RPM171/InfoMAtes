using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
   public Rigidbody2D Rigidbody2d;
   public float speed;
   public GameObject bullets;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2d = GetComponent<Rigidbody2D>();    


    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2d.velocity = Vector3.up * speed;
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "alien1")
        {
            // Aquí puedes poner el código para terminar el juego
            Destroy(collision.gameObject);
            Time.timeScale = 0;
        }
    }




}
