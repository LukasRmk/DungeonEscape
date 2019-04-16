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

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) < aggroRange)
        {

            if (Vector2.Distance(transform.position, player.position) > stoping)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            }
            else if (Vector2.Distance(transform.position, player.position) < stoping && Vector2.Distance(transform.position, player.position) > retreat)
            {
                transform.position = this.transform.position;
            }
            else if (Vector2.Distance(transform.position, player.position) < retreat)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("wall"))
        {
            transform.position = this.transform.position;
        }
    }
}
