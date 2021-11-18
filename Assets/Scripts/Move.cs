using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Move 
{
    public ushort id;
    public string name;
    public short type;
    public int power;
    public int accuracy;
    public int pp;

    public Move(byte id, string name, short type, int power, int accuracy, int pp)
    {
        this.id = id;
        this.name = name;
        this.type = type;
        this.power = power;
        this.accuracy = accuracy;
        this.pp = pp;
    }

    public Move(byte id, string name, PokeTypes type, int power, int accuracy, int pp)
    {
        this.id = id;
        this.name = name;
        this.type = (short)type;
        this.power = power;
        this.accuracy = accuracy;
        this.pp = pp;
    }

    // static Move[] moves {};
}