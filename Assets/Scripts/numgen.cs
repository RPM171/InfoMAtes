using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numgen : MonoBehaviour
{
    public GameObject prefabNumero;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("genNum",1f,3);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void genNum()
    {
        GameObject numero = Instantiate(prefabNumero);
        
    }
}
