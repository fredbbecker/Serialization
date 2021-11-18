using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Trainer
{
    public uint id;
    public string name;
    public int money;
    public float time;
    public byte badges;
    //public Pokemon[] equipped = new Pokemon[6];
    public List<Pokemon> pokemons = new List<Pokemon>();
    //public List<byte> pokemonSeen = new List<byte>(); 
    public List<Item> itens = new List<Item>();

    public Trainer() {}
    public Trainer(string name)
    {
        this.id = (uint)Random.Range(int.MinValue, int.MaxValue);
        this.name = name;
        this.money = 0;
        this.time = 0.0f;
        this.badges = 0;
    }
}

public enum Badges : byte
{
    boulder = 0x01,
    cascade = 0x02,
    thunder = 0x04,
    rainbow = 0x08,
    soul    = 0x10,
    marsh   = 0x20,
    volcano = 0x40,
    earth   = 0x80,
    none    = 0x00
}