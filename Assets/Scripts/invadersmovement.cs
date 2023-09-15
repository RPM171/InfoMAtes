using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invadersmovement : MonoBehaviour
{
    public GameObject alien;
    public float speed = 1f;
    public float movementDistance = 1f;
    public float movementDelay = 1f;
    public int rows = 5;
    public int columns = 11;
    public float spacing  = 1.5f;
    private bool movingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Moveinvaders", movementDelay, movementDelay);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (movingRight)
            
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);

        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (transform.position.x >= movementDistance)
        {
            movingRight = false;
        }
        else if (transform.position.x <= -movementDistance)
        {
            movingRight = true;
        }
        
    }
}
