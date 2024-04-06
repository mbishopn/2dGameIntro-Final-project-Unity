using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Menu;
    private bool menuActivated;


    // reference to itemslot
    // for flexibility
    public itemSlot[] itemSlot;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I) && menuActivated){
            Menu.SetActive(false);
            menuActivated = false;
        }
        else if (Input.GetKeyDown(KeyCode.I) && !menuActivated)
        {
            Menu.SetActive(true);
            menuActivated = true;

        }

    }
    public void AddItem(string itemName, int quantity, Sprite itemSprite)
    {
/*        Debug.Log("itemName" + itemName + "quantity of item" + quantity + "pic" + itemSprite);
*/ 
    
    for (int ii = 0; ii < itemSlot.Length; ii++)
        {
            if (itemSlot[ii].isFull == false)
            {
                itemSlot[ii].addItem(itemName, quantity, itemSprite);

               // once the items are added return will stop the loop, or it was adding items to every frame :D
                return;
            }
        }
    }


    public void toggleSlotsOff()
    {
        for (int ii = 0; ii < itemSlot.Length;  ii++) {

            itemSlot[ii].selectedshader.SetActive(false);

            itemSlot[ii].thisiTemSelected = false;
        }
    }
}
