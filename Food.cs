using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    Animator myAnimator;

    public void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>();
        if (player != null)
        {
            player.EatRamen();
        }
        myAnimator.SetBool("isHealed", true);
        Destroy(gameObject,0.5f);
    }
}
