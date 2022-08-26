using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform spawnPoint;
    public float fireInterval = 0.5f;
    public float bulletSpeed = 20;    
    public Rigidbody Shell;

    private Transform mCanon;
    float nextFire;

    // Start is called before the first frame update
    void Start()
    {
        nextFire = Time.time + fireInterval;
        mCanon = spawnPoint.parent;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireInterval;
            fire();
        }
    }
    void fire()
    {
        Rigidbody rbShell = Instantiate(Shell, spawnPoint.position, mCanon.rotation);
        rbShell.velocity = 5.0f * mCanon.forward;        
    }

}
