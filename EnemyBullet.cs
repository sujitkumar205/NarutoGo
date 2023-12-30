using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{   
    [SerializeField] int damage;
    public float speed = 20f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo) 
    {
            Player player = hitInfo.GetComponent<Player>();
            if (player != null)
            {
                Debug.Log("Naruto got HIT!");
                player.TakeDamage(damage);
            }
            Destroy(gameObject);
    }
}
