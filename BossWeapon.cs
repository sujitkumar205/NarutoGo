using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float fireRate = 200f;
    private float shootingTime;

    public GameObject naruto;
    public float distance;

    void Start()
    {
        shootingTime = Time.time;
        distance = naruto.transform.position.x - gameObject.transform.position.x;
    }

    void Update()
    {
        /* Vector3 relativePos = naruto.transform.position - transform.position;

         // the second argument, upwards, defaults to Vector3.up
         Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
         transform.rotation[0] = rotation[0];

         distance = Mathf.Abs(naruto.transform.position.x - gameObject.transform.position.x);

         if(distance < 10)
         {
             if (Time.time > shootingTime)
             {
                 shootingTime = Time.time + fireRate / 1000;
                 //Debug.Log("Hello");
                 Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
             }
         }*/

        if (naruto.transform.position.x > gameObject.transform.position.x)
        {
            distance = naruto.transform.position.x - gameObject.transform.position.x;
            if (distance < 20 && distance >= 0)
            {
                if (gameObject.GetComponent<EnemyMovement>().moveSpeed == -1f)
                {
                    gameObject.GetComponent<EnemyMovement>().FlipEnemyFacing();
                    gameObject.GetComponent<EnemyMovement>().moveSpeed = 1f;
                }
                if (Time.time > shootingTime)
                {
                    //distance = naruto.transform.position.x - gameObject.transform.position.x;
                    //gameObject.GetComponent<EnemyMovement>().moveSpeed = gameObject.GetComponent<EnemyMovement>().moveSpeed;
                    shootingTime = Time.time + fireRate / 1000;
                    //Debug.Log("Hello");
                    Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

                }
            }
        }
        else
        {
            distance = gameObject.transform.position.x - naruto.transform.position.x;
            if (distance < 20 && distance >= 0)
            {
                if (gameObject.GetComponent<EnemyMovement>().moveSpeed == 1f)
                {
                    gameObject.GetComponent<EnemyMovement>().FlipEnemyFacing();
                    gameObject.GetComponent<EnemyMovement>().moveSpeed = -1f;
                }
                if (Time.time > shootingTime)
                {
                    //distance = naruto.transform.position.x - gameObject.transform.position.x;
                    //gameObject.GetComponent<EnemyMovement>().moveSpeed = gameObject.GetComponent<EnemyMovement>().moveSpeed;
                    shootingTime = Time.time + fireRate / 1000;
                    //Debug.Log("Hello");
                    Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

                }
            }
        }

        /*else if (distance > -10 && distance <= 0)
        {
            if (Time.time > shootingTime)
            {
                if (gameObject.GetComponent<EnemyMovement>().moveSpeed == 1f)
                {
                    gameObject.GetComponent<EnemyMovement>().FlipEnemyFacing();
                    gameObject.GetComponent<EnemyMovement>().moveSpeed = -gameObject.GetComponent<EnemyMovement>().moveSpeed;
                }

                //distance = gameObject.transform.position.x - naruto.transform.position.x;
                shootingTime = Time.time + fireRate / 1000;
                Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                //gameObject.GetComponent<EnemyMovement>().FlipEnemyFacing();
                //gameObject.GetComponent<EnemyMovement>().moveSpeed = - gameObject.GetComponent<EnemyMovement>().moveSpeed;
            }*/
    }
    /*void OnTriggerStay2D(Collider2D hitInfo) 
    {
        Player player = hitInfo.GetComponent<Player>();
        if (Time.time > shootingTime)
        {
            shootingTime = Time.time + fireRate / 1000;
            if (player != null)
            {
                Debug.Log("Hello");
                Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            }
        }
    }*/
}

