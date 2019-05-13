using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkRetreat : MonoBehaviour
{
    public float speed;
    public float stoping;
    public float retreat;
    public float aggroRange;

    public Transform player;
    public Animator animator;
    protected Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        direction = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        direction = (player.transform.position - transform.position).normalized;
        if (Vector2.Distance(transform.position, player.position) < aggroRange)
        {

            if (Vector2.Distance(transform.position, player.position) > stoping)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
                Anim();
            }
            else if (Vector2.Distance(transform.position, player.position) < stoping && Vector2.Distance(transform.position, player.position) > retreat)
            {
                transform.position = this.transform.position;
                direction = Vector2.zero;
            }
            else if (Vector2.Distance(transform.position, player.position) < retreat)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
                Anim();
            }
        }
    }

    void Anim()
    {
        animator.SetFloat("SpeedK", direction.x);
        animator.SetFloat("SpeedD", direction.x);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("wall"))
        {
            transform.position = this.transform.position;
        }
    }
}
