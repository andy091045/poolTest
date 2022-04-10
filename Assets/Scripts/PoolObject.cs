using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolObject : MonoBehaviour
{
    bool Automatic = true;
    Vector3 destination;
    public float speed = 5;
    void Update()
    {
        destination = GameObject.Find("sheepHouseEnd").transform.position;

        if (!gameObject.activeInHierarchy)
        {
            return;
        }

        if (Automatic)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "destination")
        {
            this.gameObject.SetActive(false);
        }
    }
}
