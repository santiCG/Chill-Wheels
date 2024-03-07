using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton_Salida : MonoBehaviour
{
    public GameObject boton_normal;
    public GameObject Boton_provisional;
    public GameObject Interfaz;


    //void Start()
    //{
    //    boton_normal.SetActive(false);
    //    Interfaz.SetActive(true);
    //    Debug.Log("AAA");
    //}

    // Update is called once per frame
    

    public void onClick()
    {

        boton_normal.SetActive(true);
        Boton_provisional.SetActive(false);
        Interfaz.SetActive(false);
        Debug.Log("se detecto click");
    }
}
