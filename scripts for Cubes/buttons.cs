using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
    public string action;
    

    [System.Obsolete]
    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "Play":
                Application.LoadLevel("LoadScene 1");
                break;
        }
    }
}
