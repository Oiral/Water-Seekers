using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class WorldButton : MonoBehaviour
{
    public GameObject thingToToggle;
    
    [Tooltip("The Tag that interacts with this button"), TagSelector]
    public string tagCheck;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == tagCheck)
        {
            thingToToggle.GetComponent<IInteractable>().OnFocus(); 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == tagCheck)
        {
            thingToToggle.GetComponent<IInteractable>().OnLoseFocus();
        }
    }
}
