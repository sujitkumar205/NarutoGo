using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalFire : MonoBehaviour
{
    public GameObject gameobject;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameobject == null)
        {
            Destroy(gameObject);
        }
    }
}
