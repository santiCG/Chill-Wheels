using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tennis : MonoBehaviour
{
    public GameObject descripcion;
    //public GameObject Boton_normal;
    void Start()
    {
        descripcion.SetActive(false);

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





    public void onClick()
    {

        //descripcion.SetActive(true);
        //Boton_normal.SetActive(false);
        Debug.Log("se detecto click");
    }
}
