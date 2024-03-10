using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Horno_Pizza : MonoBehaviour
{
    [SerializeField] private Pizzas_x_segundo pizzas_x_seg;
    [SerializeField] private AmountPizzas amountPizzas;

    // Produccion del horno
    private float produccion = 1f;

    //Costo
    private int nivel = 1;
    private float costo = 5f;

    public GameObject descripcion;
    //public GameObject Boton_normal;
    void Start()
    {
        descripcion.SetActive(false);
    }

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
        if(amountPizzas.Pizzas >= costo) 
        {
            Debug.Log(costo);

            pizzas_x_seg.AumentarPiz_Seg(produccion);

            produccion += Mathf.Sqrt(produccion);

            amountPizzas.Pizzas -= costo;

            costo = nivel * 5;

            nivel++;
        }
        else
        {
            Debug.Log("No te alcanza");
        }
    }
}
