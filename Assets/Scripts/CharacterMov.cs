using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMov : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = (new Vector2(0, 0));

        if (Input.GetKey("d"))
        {
            rb.velocity = (new Vector2(speed, rb.velocity.y));
        }

        if (Input.GetKey("a"))
        {
            rb.velocity = (new Vector2(-speed, rb.velocity.y));
        }

        if (Input.GetKey("w"))
        {
            rb.velocity = (new Vector2(rb.velocity.y, speed));
        }

        if (Input.GetKey("s"))
        {
            rb.velocity = (new Vector2(rb.velocity.y, -speed));
        }

        if (Input.GetKey("d") && Input.GetKey("w"))
        {
            rb.velocity = (new Vector2(speed, speed));
        }

        if (Input.GetKey("a") && Input.GetKey("w"))
        {
            rb.velocity = (new Vector2(-speed, speed));
        }

        if (Input.GetKey("d") && Input.GetKey("s"))
        {
            rb.velocity = (new Vector2(speed, -speed));
        }

        if (Input.GetKey("a") && Input.GetKey("s"))
        {
            rb.velocity = (new Vector2(-speed, -speed));
        }

    }

    static void move()
    {

    }
}
