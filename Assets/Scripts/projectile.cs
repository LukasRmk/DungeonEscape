using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class projectile : MonoBehaviour
{

    public static AudioClip cannonSound;
    static AudioSource src;

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
        float random = Random.Range(-1, 1);
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMov>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x + random, player.position.y + random);

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
    }
}
