using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public Transform light;
    public GameObject atsiranda;

    // Start is called before the first frame update
    void Start()
    {
        light = GameObject.FindGameObjectWithTag("Light").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(atsiranda, light.position, light.rotation);
        }
    }
}
