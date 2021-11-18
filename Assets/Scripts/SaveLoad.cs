using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveLoad : MonoBehaviour
{
    public Trainer trainer = new Trainer();
    public Trainer loadedTrainer;

    void Start()
    {
        trainer.id = (uint)Random.Range(int.MinValue, int.MaxValue);
        trainer.name = "Blue";
        trainer.money = 100;
        trainer.time = Time.realtimeSinceStartup;
        trainer.badges = (byte)(Badges.boulder | Badges.cascade);

        trainer.pokemons.Add(new Pokemon(1, trainer, "Bulba", 1));
        trainer.pokemons.Add(new Pokemon(52, trainer, "Gato", 1));
        trainer.pokemons.Add(new Pokemon(25));
        trainer.pokemons.Add(new Pokemon(6));

        trainer.itens.Add(new Item(1, "Pokeball", 7));
        trainer.itens.Add(new Item(2, "Rare Candy", 1));
        trainer.itens.Add(new Item(3, "Bicycle", 1));
        trainer.itens.Add(new Item(4, "Potion", 99));
        trainer.itens.Add(new Item(55, "TM55", 1));
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveToJson();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            loadedTrainer = LoadFromJson();
        }
    }

    public void SaveToJson()
    {
        string json = JsonUtility.ToJson(trainer, true);
        string dir = Application.dataPath + "/Resources/save_file.json";
        File.WriteAllText(dir, json); 
        print("Data Saved!");
    }

    public Trainer LoadFromJson()
    {
        string dir = Application.dataPath + "/Resources/save_file.json";

        if(!File.Exists(dir))
        {
            print("No Save File!");
            return null;
        }

        string json = File.ReadAllText(dir);

        print("Data Loaded!");
        return JsonUtility.FromJson<Trainer>(json);
    }

}