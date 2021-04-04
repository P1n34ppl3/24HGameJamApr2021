using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject ui;
    public Score score;
    public float Speed = 10f;

    void Start()
    {   
        ui = GameObject.Find("Always");
        score = ui.GetComponent<Score>();
    }

    void Update()
    {
        rb.velocity = transform.forward * Time.deltaTime * Speed;
    }

    public void OnTriggerEnter(Collider collider)
    {   
        if (collider.gameObject.tag == "Enemy")
        {
            score.IncrementScore();
        }
        if (collider.gameObject.name != "Player")
        {
            Destroy(gameObject);
        }
    }

}
