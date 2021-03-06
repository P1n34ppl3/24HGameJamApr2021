using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform PPosition;
    public GameObject BulletPrefab;
    public float ReloadTime = 1f;
    int reload = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) & reload == 0)
        {
            Instantiate(BulletPrefab, PPosition.position + 3*transform.forward + new Vector3(0,1,0) , PPosition.rotation);
            reload = 1;
            Invoke("Shoot", ReloadTime);
        }
    }

    void Shoot()
    {
        reload = 0;
    }
}
