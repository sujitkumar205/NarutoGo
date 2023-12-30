using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    void Update()
    {

    }

    void OnShoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
