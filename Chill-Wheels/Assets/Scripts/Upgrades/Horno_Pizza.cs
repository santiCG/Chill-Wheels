using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horno_Pizza : MonoBehaviour
{
    public GameObject descripcion;
    //public GameObject Boton_normal;
    void Start()
    {
        descripcion.SetActive(false);
        Debug.Log("AAA");
    }

    // Update is called once per frame
    public void OnMouseOver()
    {
        descripcion.SetActive(true);
        Debug.Log("Deteccion mouse");
    }

    public void OnMouseExit()
    {
        descripcion.SetActive(false);
        Debug.Log("salida mouse");
    }

    private void OnMouseDown()
    {


        Debug.Log("se detecto click");
    }

    private void OnMouseUpAsButton()
    {
        // Aquí puedes agregar cualquier otra acción que desees realizar cuando se hace clic en el elemento del canvas.
        Debug.Log("Activar coso");
    }

    public void onClick()
    {

        //descripcion.SetActive(true);
        //Boton_normal.SetActive(false);
        Debug.Log("se detecto click");
    }
}
