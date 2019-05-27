using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    public float lifeTime;
    private ghostFollow beg;
    private float pradGreit;
    // Start is called before the first frame update
    void Start()
    {

        beg = GameObject.FindGameObjectWithTag("Boss").GetComponent<ghostFollow>();

        pradGreit = beg.speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (lifeTime >0)
        {
            lifeTime -= Time.deltaTime;
            if (lifeTime<=0)
            {
                Destruction();
            }
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Boss")
        {

            Debug.Log("nice");
            beg.speed = 0;
            StartCoroutine(waitF());

            
        }
    }

    IEnumerator waitF()
    {
        yield return new WaitForSecondsRealtime(3.95f);
        beg.speed = 2;
        //animator.SetBool("Zala", false);

    }

    void Destruction()
    {
        Destroy(this.gameObject);
    }
}
