using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spyglys : MonoBehaviour
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

    void OnCollisionEnter2D(Collision2D col)
    {
            character.damage(1);
    }

}
