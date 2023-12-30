using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour
{
    // Start is called before the first frame update

    void OnTriggerEnter2D(Collider2D hitInfo) 
    {
        Player player = hitInfo.GetComponent<Player>();
        if(player != null)
        {
            player.Die();
        }
    }
}
