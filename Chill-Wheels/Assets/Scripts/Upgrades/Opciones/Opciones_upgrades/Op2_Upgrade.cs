using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Op2_Upgrade : MonoBehaviour
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



    //void Start()
    //{
    //    Boton_Seleccionado1.SetActive(false);
    //    Boton_Seleccionado2.SetActive(true);

    //    Boton_normal1.SetActive(true);
    //    Boton_normal2.SetActive(false);

    //    Debug.Log("AAA");
    //}



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

        Boton_Seleccionado1.SetActive(false);
        Boton_Seleccionado2.SetActive(true);

        Boton_normal1.SetActive(true);
        Boton_normal2.SetActive(false);




        Iman_pizzas.SetActive(false);
        Patineta_Rapida.SetActive(false);
        Pinkbull.SetActive(false);
        Guepardex.SetActive(false);
        Harina_Pan.SetActive(false);

        Corazon_Mario.SetActive(true);
        Pizzi_Prime.SetActive(true);



        Debug.Log("se detecto click");
    }
}
