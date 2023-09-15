using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    public Vector3 direction = Vector3.up;
    public float speed = 22f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + direction * speed * Time.deltaTime;    
        
    }

}
