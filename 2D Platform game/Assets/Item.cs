using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    // makes this variable visible and editable in the unity Inspector
    private string itemName;

    [SerializeField]
    private int quantity;

    [SerializeField]
    public Sprite sprite;
    // keeps track of the image 
    // Start is called before the first frame update

    // i don't now if it could affect anything at this stage when we don't have too complicated system
    // but i thought setting them private would make it secure, so other classes if referenced would not interfere at any point
    // with the vars.
    private InventoryManager inventoryManager;
    void Start()
    {
        // to make items able to talk to Ivnentory manager referencing it here
        inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();
        
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            inventoryManager.AddItem(itemName, quantity, sprite);
            Destroy(gameObject);
        }
    }
}
