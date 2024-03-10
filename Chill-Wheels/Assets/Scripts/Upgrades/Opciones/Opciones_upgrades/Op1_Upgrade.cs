using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Op1_Upgrade : MonoBehaviour
{
    //public GameObject interfaz_mejoras;
    public GameObject Boton_normal1;
    public GameObject Boton_normal2;
 
    public GameObject Boton_Seleccionado1;
    public GameObject Boton_Seleccionado2;
   

    public GameObject Iman_pizzas;
    public GameObject Patineta_Rapida;
    public GameObject Pinkbull;
    public GameObject Guepardex;
    public GameObject Harina_Pan;

    public GameObject Corazon_Mario;
    public GameObject Pizzi_Prime;

    void Start()
    {
        Boton_Seleccionado1.SetActive(true);
        Boton_Seleccionado2.SetActive(false);

        Boton_normal1.SetActive(false);
        Boton_normal2.SetActive(true);

        Debug.Log("AAA");
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

        Boton_Seleccionado1.SetActive(true);
        Boton_Seleccionado2.SetActive(false);

        Boton_normal1.SetActive(false);
        Boton_normal2.SetActive(true);


        Iman_pizzas.SetActive(true);
        Patineta_Rapida.SetActive(true);
        Pinkbull.SetActive(true);
        Guepardex.SetActive(true);
        Harina_Pan.SetActive(true);

        Corazon_Mario.SetActive(false);
        Pizzi_Prime.SetActive(false);



        Debug.Log("se detecto click");
    }
}
