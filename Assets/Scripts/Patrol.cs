using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public Transform[] movSpots;

    private int movIndex;

    // Start is called before the first frame update
    void Start()
    {
        movIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, movSpots[movIndex].position, speed * Time.deltaTime);

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
}
