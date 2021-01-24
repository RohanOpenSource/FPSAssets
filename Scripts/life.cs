using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour
{
    public float health;
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            GetComponent<respawn>().RespawnFromPoint();
        }
                
    }

}
