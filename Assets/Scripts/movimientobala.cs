using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientobala : MonoBehaviour
{
    public disparo disparoS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            disparoS.enabled = true;

        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            disparoS.enabled = false;
        }
        if (transform.position.y <= 5)
        {
        Destroy(gameObject);
        }
    }
}
