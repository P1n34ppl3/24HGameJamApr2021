using System.Collections;
using UnityEngine;

public class FireballOrbitTrail : MonoBehaviour
{
    public GameObject Fireball;
    private float speed = 200;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OrbitAround();
    }

    void OrbitAround()
    {
        transform.RotateAround (Fireball.transform.position, Vector3.forward, speed * Time.deltaTime);
    }
}
