using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float Speed = 10f;
    public float Spawnrate = 5f;
    public GameObject Player;
    private Rigidbody rb;
    float OffsettX; 
    float OffsettZ; 
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        OffsettX = Random.Range(-10.0f, 10.0f);
        OffsettZ = Random.Range(-10.0f, 10.0f);
        rb = GetComponent<Rigidbody>();
        Invoke("Aim",2);
    }

    void Update()
    {
        
        rb.velocity = transform.forward * Speed;
    }

    void Aim()
    {
        var target = Player.GetComponent<Transform>();
        Debug.Log(target.position);
        
        var lookPos = target.position - transform.position;
        lookPos.y = 0;
        
        lookPos.x = lookPos.x + OffsettX;
        var rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 1);
    }
    

    
}
