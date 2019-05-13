using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class projectile : MonoBehaviour
{

    public static AudioClip cannonSound;
    static AudioSource src;
    public GameObject explosion;
    //public GameObject trail;
    public float speed;

    private CharacterMov character;
    private Transform player;
    private Vector2 target;
    // Start is called before the first frame update
    void Start()
    {
        cannonSound = Resources.Load<AudioClip>("cannon");
        src = GetComponent<AudioSource>();

        src.PlayOneShot(cannonSound);
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMov>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);

        var dir = player.position - transform.position;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

       // Instantiate(trail, transform.position, transform.rotation);


    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
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
