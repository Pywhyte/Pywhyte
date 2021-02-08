using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public bool teleported = false;
    public Teleport target;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!teleported)
            {
                target.teleported = true;
                other.gameObject.transform.position = target.gameObject.transform.position;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            teleported = false;
        }
    }
}
