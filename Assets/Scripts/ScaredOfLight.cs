using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaredOfLight : MonoBehaviour
{

    public float retreat;
    public float speed;
    public Transform light;
    // Start is called before the first frame update
    void Start()
    {
        light = GameObject.FindGameObjectWithTag("Light").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, light.position) < retreat)
        {
            transform.position = Vector2.MoveTowards(transform.position, light.position, -speed * Time.deltaTime);
        }
    }
}
