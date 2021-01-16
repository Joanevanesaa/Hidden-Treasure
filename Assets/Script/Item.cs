using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Item 
{
    public enum ItemType
    {
        Stone,
        Food,
        HealthPotion,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Stone: return ItemAssets.Instance.stoneSprite;
            case ItemType.Food: return ItemAssets.Instance.foodSprite;
            case ItemType.HealthPotion: return ItemAssets.Instance.healthPotionSprite;
        }

    }

    public bool IsStackable()
    {
        switch(itemType)
        {
            default:
            case ItemType.Stone:
            case ItemType.Food:
            case ItemType.HealthPotion:
                return true;
        }
    }
}
