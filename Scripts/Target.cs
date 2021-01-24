using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public ParticleSystem p;
    public void TakeDamage(float amount)
    {
        ParticleSystem l = Instantiate(p, transform.position, Quaternion.identity);
        l.Play();
        Destroy(l, 5);
        health -= amount;
        if (health <= 0)
        {
            ParticleSystem m=Instantiate(p,transform.position, Quaternion.identity);
            m.Play();
            Destroy(m, 5);
            Destroy(gameObject);
        }
    }
}
