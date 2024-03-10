using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pizzas_x_segundo : MonoBehaviour
{
    [SerializeField] private AmountPizzas PuntajePizzas;

    private float pizzas_seg;

    private TextMeshProUGUI _textMeshPro;

    private float tiempoPasado = 0f;
    private float tiempoEsperado = 1f;

    private void Start()
    {
        _textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        _textMeshPro.text = pizzas_seg.ToString("0");

        tiempoPasado += Time.deltaTime;
        if (tiempoPasado >= tiempoEsperado)
        {
            PuntajePizzas.SumarPizzas(pizzas_seg);

            tiempoPasado = 0f; // Reinicia el contador.
        }
    }

    public void AumentarPiz_Seg(float nuevoValor)
    {
        pizzas_seg = nuevoValor;
    }
}
