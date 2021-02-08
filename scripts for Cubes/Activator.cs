using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public GameObject[] firstGroup;
    public GameObject[] secondGroup;
    public Activator buttom;
    public Material normal;
    public Material transparent;
    public bool canPush;

    private void OnTriggerEnter(Collider other)
    {
        if(canPush)
        {
            foreach (GameObject first in firstGroup)
            {
                first.GetComponent<Renderer>().material = normal;
                first.GetComponent<Collider>().isTrigger = false;
            }
            foreach (GameObject second in secondGroup)
            {
                second.GetComponent<Renderer>().material = transparent;
                second.GetComponent<Collider>().isTrigger = true;
            }
            GetComponent<Renderer>().material = transparent;
            buttom.GetComponent<Renderer>().material = normal;
            buttom.canPush = true;
        }
        if(other.CompareTag("Cube") || other.CompareTag("Player"))
        {
            foreach(GameObject first in firstGroup)
            {
                first.GetComponent<Renderer>().material = normal;
                first.GetComponent<Collider>().isTrigger = false;
            }
            foreach (GameObject second in secondGroup)
            {
                second.GetComponent<Renderer>().material = transparent;
                second.GetComponent<Collider>().isTrigger = true;
            }
            GetComponent<Renderer>().material = transparent;
            buttom.GetComponent<Renderer>().material = normal;
        }
    }
}
