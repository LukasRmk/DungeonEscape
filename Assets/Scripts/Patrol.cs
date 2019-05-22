using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public Transform[] movSpots;
    public Animator animator;
    protected Vector2 direction;
    private int movIndex;

    // Start is called before the first frame update
    void Start()
    {
        movIndex = 0;
        direction = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, movSpots[movIndex].position, speed * Time.deltaTime);
        direction = (movSpots[movIndex].transform.position - transform.position).normalized;
        Anim();
        if (Vector2.Distance(transform.position, movSpots[movIndex].position) < 0.1f)
        {

            if (movIndex < movSpots.Length - 1)
            {
                movIndex++;
            }
            else
            {
                movIndex = 0;
            }
        }
    }

    void Anim()
    {
        animator.SetFloat("SpeedK", direction.x);
        animator.SetFloat("SpeedD", direction.x);
    }

}
