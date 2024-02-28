using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaCollectible : MonoBehaviour
{
    [SerializeField] private float cantidadPizzas;

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)
        {
            controller.ContadorPizzas(cantidadPizzas);

            Destroy(gameObject);
        }
    }
}
