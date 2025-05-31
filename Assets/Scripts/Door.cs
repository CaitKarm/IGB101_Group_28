using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door;
    public GameObject player;
    public Animation anim;
    public float doorProximity = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, door.transform.position) <= doorProximity)
        {
            anim.Play();
        }
        else
        {
            anim.Stop();
        }
    }
}
