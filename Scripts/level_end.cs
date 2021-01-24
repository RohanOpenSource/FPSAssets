using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_end : MonoBehaviour
{
    public Transform tppoint;
    public LayerMask enemy;
    public MeshRenderer text;
    private void Start()
    {
        text.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<WallRunTutorial>()!= null && !Physics.CheckSphere(transform.position, 5000f, enemy))
        {
            other.transform.position = tppoint.position;
            text.enabled = true;
        }
        
    }
}
