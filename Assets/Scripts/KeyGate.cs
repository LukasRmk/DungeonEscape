using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGate : MonoBehaviour
{

    public GameObject Smoke;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && GameVariables.haveKey)
        {
            GameVariables.haveKey = false;
            Destroy(gameObject);
            Instantiate(Smoke, transform.position, transform.rotation);
        }

    }
}
