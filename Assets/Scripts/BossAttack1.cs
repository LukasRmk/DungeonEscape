using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack1 : MonoBehaviour
{
    private float TimeBtwAttack;
    public float startTimeBtwAttack;
    public float range;
    private Transform target;
    private CharacterMov character;
    public Animator animator;
    private float TimeBtwAttack2;


    int maxHealth;
    private bOSS boss;
    private ghostFollow beg;
    public LayerMask whatIsEnemies;
    public Transform attackPos;
    public float attackRange;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMov>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        boss = GameObject.FindGameObjectWithTag("Boss").GetComponent<bOSS>();
        beg = GameObject.FindGameObjectWithTag("Boss").GetComponent<ghostFollow>();
        maxHealth = boss.health;
        TimeBtwAttack2 = TimeBtwAttack / 2;
    }

    // Update is called once per frame
    void Update()
    {
        
        //animator.SetBool("Smugis", false);

        
        if(boss.health <= maxHealth/2)
        {
            Smugis2();
            beg.speed = 3.5f;
            if (boss.health == maxHealth / 2)
            {
                animator.SetBool("taunt", true);
                StartCoroutine(wait3());
            }
        }
        else
        {
            Smugis1();
        }

        
    }
    public void Smugis1()
    {
        if (TimeBtwAttack <= 0)
        {
            if (Vector2.Distance(transform.position, target.position) < range)
            {
                Collider2D[] damagePlayer = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);

                animator.SetBool("Smugis", true);
                character.bossDamage(1);

                StartCoroutine(wait());
            }

            TimeBtwAttack = startTimeBtwAttack;
        }
        else
        {
            TimeBtwAttack -= Time.deltaTime;
        }
    }

    public void Smugis2()
    {
        
        if (TimeBtwAttack2 <= 0)
        {
            if (Vector2.Distance(transform.position, target.position) < range)
            {
                Collider2D[] damagePlayer = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);

                animator.SetBool("Smugis2", true);
                character.bossDamage(1);

                StartCoroutine(wait2());
            }

            TimeBtwAttack2 = startTimeBtwAttack;
        }
        else
        {
            TimeBtwAttack2 -= Time.deltaTime;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
    IEnumerator wait()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        animator.SetBool("Smugis", false);
    }
    IEnumerator wait2()
    {
        yield return new WaitForSecondsRealtime(0.7f);
        animator.SetBool("Smugis2", false);
    }
    IEnumerator wait3()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        animator.SetBool("taunt", false);
    }
}
