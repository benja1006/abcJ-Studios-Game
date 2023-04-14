using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveSpeedBoost : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        PlayerBehavior player = other.GetComponent<PlayerBehavior>();
        if(!player.BoostOnCD)
        {
            player.StartSpeedBoost();
        }
        
    }
}
