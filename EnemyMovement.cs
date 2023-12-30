using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 1f;
    public Rigidbody2D myRigidbody;
    public Transform firePoint;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        myRigidbody.velocity = new Vector2(moveSpeed, 0f);
    }
    void OnTriggerExit2D(Collider2D other) {
        Bullet bullet = other.GetComponent<Bullet>();
        if (bullet == null)
        {
            moveSpeed = -moveSpeed;
            FlipEnemyFacing();
        }
    }

    public void FlipEnemyFacing() {
        float temp1 = Mathf.Sign(transform.localScale.x);

        transform.Rotate(0f, 180f, 0f);
        bool playerHasHorizontalSpeed = Mathf.Abs(myRigidbody.velocity.x) > Mathf.Epsilon;
        //float temp1 = Mathf.Sign(transform.localScale.x);

        if (playerHasHorizontalSpeed)
        {
            //transform.localScale = new Vector2(Mathf.Sign(myRigidbody.velocity.x), 0.75f);
            float temp2 = Mathf.Sign(transform.localScale.x);
            
            if(temp1 != temp2){
                firePoint.Rotate(0f, 180f, 0f);
            }
            else{
                firePoint.Rotate(0f, 0f, 0f);
            }
            
        }
    }
}
