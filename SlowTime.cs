using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTime : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        PlayerBehavior player = other.GetComponent<PlayerBehavior>();
        if(!player.BoostOnCD)
        {
            player.StartSlowTime();
        }
        
    }
}
