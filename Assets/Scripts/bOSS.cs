using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bOSS : MonoBehaviour
{

    public int health;
    public Animator animator;
    public Slider healthBar;
    private ghostFollow beg;
    private float pradGreitis;

    public GameObject key;

    public float invLenght;
    private float invCounter;
    public Text Warning;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = health;


    }
    public void damage(int dmg)
    {
        if (health > 0) {
            health -= dmg;
            animator.SetBool("Zala", true);
            StartCoroutine(wait());
            if(health == 0)
            {
                animator.SetBool("Mirtis", true);
                StartCoroutine(waitMirtisAnim());

                StartCoroutine(waitMirtis());
                Destroy(gameObject, 0.5f);

                Instantiate(key, transform.position, Quaternion.identity);
            }
        }

        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Freeze(Clone)")
        {
            Warning.text = ("Arrrghhh!!");

            beg.speed = 0;
            StartCoroutine(waitF());
            //beg.speed = pradGreitis;
        }
    }

    IEnumerator waitF()
    {
        yield return new WaitForSecondsRealtime(3f);
        //animator.SetBool("Zala", false);
    }

    IEnumerator wait()
    {
        yield return new WaitForSecondsRealtime(0.25f);
        animator.SetBool("Zala", false);
    }
    IEnumerator waitMirtis()
    {
        yield return new WaitForSecondsRealtime(2);

    }
    IEnumerator waitMirtisAnim()
    {
        yield return new WaitForSecondsRealtime(1f);
        animator.SetBool("Mirtis", false);

    }
}
