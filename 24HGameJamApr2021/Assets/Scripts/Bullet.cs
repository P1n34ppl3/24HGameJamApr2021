using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    public float Speed = 10f;

    void Update()
    {

        rb.velocity = transform.forward * Speed;
    }

}
