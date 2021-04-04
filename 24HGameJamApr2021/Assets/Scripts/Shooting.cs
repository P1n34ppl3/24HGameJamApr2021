using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private Transform Player;
    public GameObject BulletPrefab;
    public float ReloadTime = 1f;

    void Update()
    {
        Trigger();
    }
    void Trigger()
    {
        Invoke("Shoot", ReloadTime);
    }
    void Shoot()
    {
        Instantiate(BulletPrefab, Player.position, Player.rotation);
    }
}
