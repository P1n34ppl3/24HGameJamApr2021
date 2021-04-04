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

    public void OnTriggerEnter(Collider collider)
    {   
        if (collider.gameObject.tag == "Enemy")
        {
            Score.CurrentScore += 1;
            print(Score.CurrentScore);
            print("score goes up");
        }
        if (collider.gameObject.name != "Player" & collider.gameObject.name != "Enemy")
        {
            Destroy(gameObject);
        }
    }

}
