using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public ushort id;
    public string name;
    public uint quantity;

    public Item(ushort id, string name, uint quantity)
    {
        this.id = id;
        this.name = name;
        this.quantity = quantity;
    }
}