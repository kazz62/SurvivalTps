using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehaviour : MonoBehaviour
{
    [SerializeField] private Animator playerAnimator;
    [SerializeField] public Inventory inventory;
    [SerializeField] MoveBehaviour playerMoveBehaviour;
    private Item currentItem;
    public void DoPickup(Item item)
    {
        currentItem = item;
        playerAnimator.SetTrigger("Pickup");
        playerMoveBehaviour.canMove = false;       
    }
    public void AddItemToInventory()
    {
        inventory.AddItem(currentItem.itemData);
        Destroy(currentItem.gameObject);
        currentItem = null;
    }

    public void ReEnablePlayerMovement()
    {
        playerMoveBehaviour.canMove = true; 
    }
}
