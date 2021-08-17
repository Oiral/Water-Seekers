using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class PlayerInteraction : MonoBehaviour
{
    public static PlayerInteraction instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }else if (instance != this)
        {
            Debug.LogWarning("Two Player Interactions in the same scene", gameObject);
            Destroy(this);
        }
    }

    public IInteractable currentInteractable;

    public void OnPrimaryInteraction(InputValue value)
    {
        if (currentInteractable != null)
        {
            currentInteractable.Interact();
        }
    }

}
