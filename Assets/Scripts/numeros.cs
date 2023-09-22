using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numeros : MonoBehaviour
{
    private float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        velocidad = 2f;

        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 novaPos = transform.position;
        novaPos.y = novaPos.y - velocidad * Time.deltaTime;
        transform.position = novaPos;
        
    }
    private void destroyOut()
    {
        Vector2 costatInferiorEsquerra = Camera.main.ViewportToWorldPoint(new Vector2(0f,1f));
        if (transform.position.y <= costatInferiorEsquerra.y)
        {
            Destroy(gameObject);
        }
    }
}
