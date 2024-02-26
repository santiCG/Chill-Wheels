using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 100f;
    public float JumpHeight;
    public bool InAir = false;

    int pizzas;

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        InAir = false;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        InAir = true;
    }

    void Update()
    {
        Vector2 NoMovement = new Vector2(0f, 0f);

        rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (InAir == false)
            {
                rb2d.AddForce(new Vector2(0, JumpHeight * 1.5f), ForceMode2D.Impulse);
            }
        }

        Debug.Log("Contador de pizzas: " + pizzas);
    }

    public void ContadorPizzas(int amount)
    {
        pizzas += amount;
    }
}