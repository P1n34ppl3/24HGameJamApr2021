using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float Speed = 10f;
    public float AimSpeed = 1f;
    public GameObject Player;
    public GameObject canvas;
    public Menu menu;
    private Rigidbody rb;
    float OffsettX; 
    float OffsettZ; 
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        OffsettX = Random.Range(-10.0f, 10.0f);
        OffsettZ = Random.Range(-10.0f, 10.0f);
        rb = GetComponent<Rigidbody>();
        Invoke("Aim", AimSpeed);

        canvas = GameObject.Find("Canvas");
        menu = canvas.GetComponent<Menu>();
    }

    void Update()
    {
        
        rb.velocity = transform.forward * Time.deltaTime * Speed;
    }

    void Aim()
    {
        var target = Player.GetComponent<Transform>();
        
        var lookPos = target.position - transform.position;
        lookPos.y = 0;
        lookPos.z = lookPos.z + OffsettZ;
        lookPos.x = lookPos.x + OffsettX;
        var rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 1);
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            menu.Death();
        }
        if (collider.gameObject.tag != "Enemy")
        {
            DestroyObject();
        }
        
    }

    public void DestroyObject()
    {
        //Spawn deathenemyobject
        Destroy(gameObject);
    }   
    
}
