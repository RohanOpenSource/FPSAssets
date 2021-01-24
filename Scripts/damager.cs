using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damager : MonoBehaviour
{
    private void Awake()
    {
        Destroy(gameObject, 5);
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Destroy(gameObject);
        WallRunTutorial w=collision.collider.GetComponent<WallRunTutorial>();
        if (w != null)
        {
            collision.collider.GetComponent<life>().TakeDamage(20);
        }
    }
}
