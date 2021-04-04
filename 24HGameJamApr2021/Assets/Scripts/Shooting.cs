using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform PPosition;
    public GameObject BulletPrefab;
    public float ReloadTime = 1f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("shoot");
            Debug.Log(PPosition.position);
            Debug.Log(PPosition.rotation);

            Instantiate(BulletPrefab, PPosition.position, PPosition.rotation);
        }
    }
    void Trigger()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Invoke("Shoot", ReloadTime);
        }
    }
    void Shoot()
    {
        Debug.Log("shoot");
            Instantiate(BulletPrefab, PPosition.position, PPosition.rotation);
        
           
    }
}
