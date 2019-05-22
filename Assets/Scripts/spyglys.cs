using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spyglys : MonoBehaviour
{
    private CharacterMov character;
    private bOSS boss;
    Scene scene;

    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMov>();
        boss = GameObject.FindGameObjectWithTag("Boss").GetComponent<bOSS>();
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && scene.name == "Boos map")
        {
            character.bossDamage(1);
        }

        else if (collision.CompareTag("Player"))
        {
            character.damage(1);
        }
        else if (collision.CompareTag("Boss"))
        {
            boss.damage(1);
        }
    }

}
