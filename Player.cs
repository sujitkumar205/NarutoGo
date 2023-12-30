using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int health;
    public int maxHealth = 1000;
    Animator myAnimator;

    public HealthBar healthBar;

    public void Start()
    {
        health = maxHealth;
        myAnimator = GetComponent<Animator>();
    }

    public void Update()
    {
        if (gameObject.transform.position.y < -10)
        {
            Die();
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }

        healthBar.SetHealth(health);

    }

    public void EatRamen()
    {

        health += 500;
        if (health > maxHealth)
        {
            health = maxHealth;
        }

        healthBar.SetHealth(health);

    }

    public void Die()
    {
        myAnimator.SetBool("isDead", true);

        Destroy(gameObject, 0.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


    }

    void OnCollisionEnter2D(Collision2D hitInfo)
    {
        string layer = LayerMask.LayerToName(hitInfo.collider.gameObject.layer);
        if (layer == "Enemies")
        {
            TakeDamage(100);
        }
    }
}
