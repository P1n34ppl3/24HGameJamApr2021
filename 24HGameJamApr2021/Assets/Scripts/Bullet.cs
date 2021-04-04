using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rb;
    public float Speed = 10f;

    void Update()
    {

        rb.velocity = transform.forward * Time.deltaTime * Speed;
    }

}
