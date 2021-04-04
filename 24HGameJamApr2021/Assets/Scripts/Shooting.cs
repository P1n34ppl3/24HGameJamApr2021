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
        Instantiate(BulletPrefab, PPosition.position, PPosition.rotation);   
    }
}
