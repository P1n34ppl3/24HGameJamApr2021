using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballRotate : MonoBehaviour
{
    public GameObject Fireball;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Fireball.transform.position, Vector3.right, speed * Time.deltaTime);
    }
}
