using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class cannonBall : MonoBehaviour
{

    private bool m_FacingRight = true; 
    public static AudioClip cannonSound;
    static AudioSource src;
    public GameObject explosion;
    public float speed;
    private CharacterMov character;

    public Rigidbody2D rb;

    void Start()
    {
        cannonSound = Resources.Load<AudioClip>("cannon");
        src = GetComponent<AudioSource>();
        src.PlayOneShot(cannonSound);

        character = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMov>();

        rb.velocity = transform.right * speed;
    }

    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            DestroyProjectile();
            character.damage(1);
        }

        if (collision.CompareTag("wall"))
        {
            DestroyProjectile();
        }
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
        Explode();
    }


    void Explode()
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }

   
}
