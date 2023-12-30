using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    Animator myAnimator;

    public void Start() {
        myAnimator = GetComponent<Animator>();
    }
    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        myAnimator.SetBool("isDead", true);
        
        Destroy(gameObject, 0.5f);
        
    }
}
