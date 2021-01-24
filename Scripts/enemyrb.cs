using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyrb : MonoBehaviour
{
    private GameObject Player;
    public LayerMask WhatIsPlayer;
    public float speed = 4;
    private Rigidbody rb;
    public float damageAmount;
    private bool canAttack=true;
    public float cooldownTime;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Physics.CheckSphere(transform.position, 50, WhatIsPlayer) && !Physics.CheckSphere(transform.position, 2f, WhatIsPlayer))
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, Player.transform.position, speed * Time.fixedDeltaTime);
            rb.MovePosition(pos);
            transform.LookAt(Player.transform);

        }

    }
    private void Update()
    {
        if (Physics.CheckSphere(transform.position, 5f, WhatIsPlayer)&& canAttack)
        {
            Player.GetComponent<life>().TakeDamage(damageAmount);
            canAttack = false;
            StartCoroutine(cooldown(cooldownTime));

        }
        if(transform.position.y <= -60)
        {
            Destroy(gameObject);
        }
       


        IEnumerator cooldown(float time)
        {
            
            yield return new WaitForSeconds(time);
            canAttack = true;
        }
    }
}
