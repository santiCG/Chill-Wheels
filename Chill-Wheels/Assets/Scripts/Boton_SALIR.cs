using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton_SALIR : MonoBehaviour
{

    public GameObject Boton_Salir;

    void Start()
    {
        Boton_Salir.SetActive(false);
        Debug.Log("AAA");
    }

    // Update is called once per frame
    private void OnMouseOver()
    {
        Boton_Salir.SetActive(true);
        Debug.Log("Deteccion mouse");
    }

    private void OnMouseExit()
    {
        Boton_Salir.SetActive(false);
        Debug.Log("salida mouse");
    }

    private void OnMouseDown()
    {
        Application.Quit();
        Debug.Log("salida programa");
    }
}
