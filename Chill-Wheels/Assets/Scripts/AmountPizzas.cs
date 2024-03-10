using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmountPizzas : MonoBehaviour
{
    private float pizzas;

    private TextMeshProUGUI _textMeshPro;

    private void Start()
    {
        _textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        _textMeshPro.text = pizzas.ToString("0");
    }

    public float Pizzas
    {
        get { return pizzas; }
        set { pizzas = value; }
    }

    public void SumarPizzas (float cantidadPizzas)
    {
        Pizzas += cantidadPizzas;
    }
}
