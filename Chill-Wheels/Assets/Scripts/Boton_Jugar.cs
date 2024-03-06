using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boton_Jugar : MonoBehaviour
{
    public GameObject Boton_jugar;
    public int indiceNivel;

    void Start()
    {
        Boton_jugar.SetActive(false);
        Debug.Log("AAA");
    }

    // Update is called once per frame
    private void OnMouseOver()
    {
        Boton_jugar.SetActive(true);
        Debug.Log("Deteccion mouse");
    }

    private void OnMouseExit()
    {
        Boton_jugar.SetActive(false);
        Debug.Log("salida mouse");
    }

    private void OnMouseDown()
    {

        SceneManager.LoadScene(indiceNivel);
        Debug.Log("cambiod e nivel");
    }
}
