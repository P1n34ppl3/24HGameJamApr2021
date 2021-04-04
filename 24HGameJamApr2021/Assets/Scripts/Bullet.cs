using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject BulletDeath;
    public Rigidbody rb;
    public float Speed = 10f;

    void Update()
    {
        rb.velocity = transform.forward * Speed;
    }

    public void OnTriggerEnter(Collider collider)
    {   
        if (collider.gameObject.tag == "Enemy")
        {
            Score.CurrentScore += 1;
            print(Score.CurrentScore);
            print("score goes up");
            collider.GetComponent<EnemyMove>().DestroyObject();

        }
        if (collider.gameObject.name != "Player") 
        {
            Instantiate(BulletDeath, transform.position, Quaternion.Euler(0,0,0));
            Destroy(gameObject);
        }
    }

}
