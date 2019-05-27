using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ghostFollow : MonoBehaviour
{

    public float speed;
    public float aggrorange;
    private Transform target;
    private CharacterMov character;
    public Animator animator;
    protected Vector2 direction;
    Scene scene;

    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMov>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        direction = Vector2.zero;
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("SpeedK", 0);
        animator.SetFloat("SpeedD", 0);
        if (Vector2.Distance(transform.position, target.position) < aggrorange)
        {
            direction = (target.transform.position - transform.position).normalized;
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            Anim();
        }
    }

    void Anim()
    {
        animator.SetFloat("SpeedK", direction.x);
        animator.SetFloat("SpeedD", direction.x);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && scene.name == "Boos map")
        {

        }

        else if (collision.CompareTag("Player"))
        {
            character.damage(1);
        }

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && scene.name == "Boos map")
        {

        }

        else if (collision.CompareTag("Player"))
        {
            character.damage(1);
        }
    }
}
