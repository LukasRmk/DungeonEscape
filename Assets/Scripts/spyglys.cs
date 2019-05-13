using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spyglys : MonoBehaviour
{
    private CharacterMov character;
    private bOSS boss;

    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMov>();
        boss = GameObject.FindGameObjectWithTag("Boss").GetComponent<bOSS>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            character.damage(1);
        }
        if (collision.CompareTag("Boss"))
        {
            boss.damage(1);
        }
    }

}
