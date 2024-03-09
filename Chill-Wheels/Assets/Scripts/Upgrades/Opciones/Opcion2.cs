using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opcion2 : MonoBehaviour
{
    //public GameObject interfaz_mejoras;
    public GameObject Boton_normal1;
    public GameObject Boton_normal2;
    public GameObject Boton_normal3;
    public GameObject Boton_Seleccionado1;
    public GameObject Boton_Seleccionado2;
    public GameObject Boton_Seleccionado3;

    public GameObject Horno;
    public GameObject Granjas;
    public GameObject Tennis;
    public GameObject Tabla_Skate;
    public GameObject Casco;

    public GameObject Llantitas;
    public GameObject Coderas;
    public GameObject Rodilleras;
    public GameObject Franquicia_Pizzas;
    public GameObject Italianos_Enojados;

    public GameObject Amuleto_Pepperoni;




    //void Start()
    //{
    //    Boton_Seleccionado1.SetActive(true);
    //    Boton_Seleccionado2.SetActive(false);
    //    Boton_Seleccionado3.SetActive(false);
    //    Boton_normal1.SetActive(false);
    //    Boton_normal2.SetActive(true);
    //    Boton_normal3.SetActive(true);
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
        Boton_Seleccionado3.SetActive(false);
        Boton_normal1.SetActive(true);
        Boton_normal2.SetActive(false);
        Boton_normal3.SetActive(true);

        Horno.SetActive(false);
        Granjas.SetActive(false);
        Tennis.SetActive(false);
        Tabla_Skate.SetActive(false);
        Casco.SetActive(false);

        Llantitas.SetActive(true);
        Coderas.SetActive(true);
        Rodilleras.SetActive(true);
        Franquicia_Pizzas.SetActive(true);
        Italianos_Enojados.SetActive(true);

        Amuleto_Pepperoni.SetActive(false);

        Debug.Log("se detecto click");
    }
}
