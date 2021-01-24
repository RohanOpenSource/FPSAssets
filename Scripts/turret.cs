using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour
{
    public GameObject bullet;
    public Transform Player;
    public LayerMask WhatIsPlayer;
    public Transform firepoint;
    private float nexttimetofire = 0f;
    public float firerate;

    void Update()
    {
        transform.LookAt(Player);
        if (Physics.CheckSphere(transform.position,70f,WhatIsPlayer)&& Time.time >= nexttimetofire)
        {
            nexttimetofire = Time.time + 1f / firerate;
            Rigidbody r=Instantiate(bullet, firepoint.position, transform.rotation).GetComponent<Rigidbody>();
            r.AddForce(transform.forward * 32f, ForceMode.Impulse);

        }

    }

}
