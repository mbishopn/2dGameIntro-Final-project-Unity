using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
public class itemSlot : MonoBehaviour, IPointerClickHandler
{

    // -----------------ITEM DATA HER-----------------------------

    public string itemName;
    public int quantity;
    public Sprite itemSprite;
    public bool isFull;


    // ------------------------ITEM SLOT HERE--------------

    [SerializeField]
    private TMP_Text quantityText;

    [SerializeField]
    private Image itemImage;




    public GameObject selectedshader;

    public bool thisiTemSelected;


    public TMP_Text itemDescriptionNameText;


    private InventoryManager inventoryManager;
    // Start is called before the first frame update

    private void Start()
    {
        inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();
    }
    public void addItem(string itemName, int quantity, Sprite itemSprite)
    {
        this.itemName = itemName;

        this.quantity = quantity;
        this.itemSprite = itemSprite;

        quantityText.text = quantity.ToString();
        quantityText.enabled = true;
        itemImage.sprite = itemSprite;
        /*itemImage.enabled = true;*/
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            onLeftClick();

        }
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            onRightClick();
        }


        
    }

    public void onLeftClick() {

        inventoryManager.toggleSlotsOff();

        selectedshader.SetActive(true);
        thisiTemSelected = true;

       /* itemDescriptionNameText.text = itemName;*/


    }


    public void onRightClick() { }
}