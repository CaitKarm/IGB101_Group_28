using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonballScript : MonoBehaviour
{
    public GameObject projectile;
    public float launchVelocity = 700f;
    public float interval = 3f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CannonballFire", interval, interval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CannonballFire()
    {
        GameObject cannonball = Instantiate(projectile, transform.position, transform.rotation);
        cannonball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(-launchVelocity, launchVelocity, 0));
    }
}
