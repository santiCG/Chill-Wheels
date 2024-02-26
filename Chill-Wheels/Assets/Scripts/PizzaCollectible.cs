using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaCollectible : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)
        {
            controller.ContadorPizzas(1);
            Destroy(gameObject);
        }
    }
}
