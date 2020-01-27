using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float bulletSpeed = 20;
    public Transform player;
    public Transform bulletSpawnPoint;
    public GameObject enemyBulletPrefab;
    public Transform target;

    private Rigidbody bulletRigidBody;
    private GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        if (!target)
        {
            target = player;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        bullet = Instantiate(enemyBulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bulletRigidBody = bullet.GetComponentInChildren<Rigidbody>();
        bullet.transform.LookAt(target);
        Vector3 shootDirection = Vector3.Normalize(target.position - bulletSpawnPoint.position);
        bulletRigidBody.AddForce(shootDirection * 20, ForceMode.Impulse);
    }
}
