using System.Collections;
using System.Collections.Generic;
using NPCSystem;
using QuestSystem;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class InteractableEventEmitter : MonoBehaviour, IInteractable
{

    public UnityEvent interactEvent;


    public void Interact()
    {
        interactEvent?.Invoke();
    }

}
