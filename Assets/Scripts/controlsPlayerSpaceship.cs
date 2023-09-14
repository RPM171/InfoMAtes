using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class controlsPlayerSpaceship : MonoBehaviour
{
    private float vMovement = 7f;
    private Camera mainCamera;
    private float minX, maxX, minY, maxY;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        CalcularLimitesDeCamara();


    }

    // Update is called once per frame
    void Update()
    {
        //movimiento
        float desplazamiento = vMovement * Time.deltaTime;
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 nuevaPosicion = transform.position + new Vector3(movimientoHorizontal * desplazamiento, movimientoVertical * desplazamiento, 0);
        
        transform.position = nuevaPosicion;

        //limite de pantalla
        // Obtener la posici�n actual del objeto
        Vector3 posicionActual = transform.position;

        // Limitar el movimiento horizontal
        posicionActual.x = Mathf.Clamp(posicionActual.x, minX, maxX);

        // Limitar el movimiento vertical
        posicionActual.y = Mathf.Clamp(posicionActual.y, minY, maxY);

        // Aplicar la nueva posici�n limitada al objeto
        transform.position = posicionActual;


    }
    void CalcularLimitesDeCamara()
    {
        // Obtener los l�mites de la c�mara en unidades del mundo
        Vector3 esquinaInferiorIzquierda = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 esquinaSuperiorDerecha = mainCamera.ViewportToWorldPoint(new Vector3(1, 1, 0));

        // Establecer los l�mites
        minX = esquinaInferiorIzquierda.x;
        maxX = esquinaSuperiorDerecha.x;
        minY = esquinaInferiorIzquierda.y;
        maxY = esquinaSuperiorDerecha.y;
    } 
}
