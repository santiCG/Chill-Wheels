using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boton_Mejoras : MonoBehaviour
{
    public GameObject interfaz_mejoras;
    public GameObject Boton_normal;
    public GameObject Boton_provisional;
  

    void Start()
    {
        interfaz_mejoras.SetActive(false);
        Boton_provisional.SetActive(false);
        Debug.Log("AAA");
    }

    // Update is called once per frame
    private void OnMouseOver()
    {
        interfaz_mejoras.SetActive(true);
        Debug.Log("Deteccion mouse");
    }

    private void OnMouseExit()
    {
        interfaz_mejoras.SetActive(false);
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
       
        interfaz_mejoras.SetActive(true);
        Boton_normal.SetActive(false);
        Boton_provisional.SetActive(true);
        Debug.Log("se detecto click");
    }
}
