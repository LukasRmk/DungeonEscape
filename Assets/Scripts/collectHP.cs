using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectHP : MonoBehaviour
{

    private CharacterMov character;

    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMov>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            character.gainHP(1);
            Destroy(gameObject);
        }
    }
}

