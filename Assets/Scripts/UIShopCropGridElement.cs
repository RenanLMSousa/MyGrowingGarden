using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIShopCropGridElement : UIShopGridElement
{
    public TMP_Text txtSellingPrice;
    public TMP_Text txtTime;
    public override void DisplayItem(Item item)
    {
        this.item = item;
        itemScriptableObject = (CropScriptableObject)item.ItemScriptableObject;
        setItemImage();
        setTxtBuyingPrice();
        setTxtName();
        txtSellingPrice.text = ((CropScriptableObject)itemScriptableObject).sellingPrice.ToString() +" Seconds";
        txtTime.text = ((CropScriptableObject)itemScriptableObject).growthTime.ToString();
    }


}