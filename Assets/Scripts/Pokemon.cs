using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Pokemon
{
    public uint id;
    public byte number;
    public uint trainerId;
    public string trainerName;
    public string nickname;
    public uint level;
    public List<Move> moves = new List<Move>();

    public Pokemon(byte number, uint trainerId, string trainerName, string nickname, uint level )
    {
        this.number = number;
        this.id = (uint)Random.Range(int.MinValue, int.MaxValue);
        this.trainerId = trainerId;
        this.trainerName = trainerName;
        this.nickname = nickname;
        this.level = level;

        moves.Add(new Move(0, "Absorb", PokeTypes.grass, 20, 100, 20 ));
        moves.Add(new Move(1, "Acid", PokeTypes.poison, 40, 100, 20 ));
        moves.Add(new Move(2, "Acid Armor", PokeTypes.poison, 0, 100, 40 ));
        moves.Add(new Move(3, "Agility", PokeTypes.psychic, 0, 100, 30 ));
    }

    public Pokemon(byte number, Trainer trainer, string nickname, uint level )
    {
        this.number = number;
        this.id = (uint)Random.Range(int.MinValue, int.MaxValue);
        this.trainerId = trainer.id;
        this.trainerName = trainer.name;
        this.nickname = nickname;
        this.level = level;

        moves.Add(new Move(0, "Absorb", PokeTypes.grass, 20, 100, 20 ));
        moves.Add(new Move(1, "Acid", PokeTypes.poison, 40, 100, 20 ));
        moves.Add(new Move(2, "Acid Armor", PokeTypes.poison, 0, 100, 40));
        moves.Add(new Move(3, "Agility", PokeTypes.psychic, 0, 100, 30 ));
    }

    public Pokemon(byte number)
    {
        this.number = number;
        this.id = (uint)Random.Range(int.MinValue, int.MaxValue);
        this.trainerId = uint.MaxValue;
        this.trainerName = "None";
        this.nickname = PokeData.pokeData[number].name;
        this.level = (uint)Random.Range(1,99);

        moves.Add(new Move(0, "Absorb", PokeTypes.grass, 20, 100, 20 ));
        moves.Add(new Move(1, "Acid", PokeTypes.poison, 40, 100, 20 ));
        moves.Add(new Move(2, "Acid Armor", PokeTypes.poison, 0, 100, 40));
        moves.Add(new Move(3, "Agility", PokeTypes.psychic, 0, 100, 30 ));
    }
 }

public enum PokeTypes : short{
    normal = 0x0001,
    fire = 0x0002,
    water = 0x0004,
    electric = 0x0008,
    grass = 0x0010,
    ice = 0x0020,
    fighting = 0x0040,
    poison = 0x0080,
    ground = 0x0100,
    flying = 0x0200,
    psychic = 0x0400,
    bug = 0x0800,
    rock = 0x1000,
    ghost = 0x2000,
    dragon = 0x4000
}

public class PokeData 
{  
    public byte number;
    public string name;
    public short types;

    public PokeData(byte number, string name, short types)
    {
        this.number = number;
        this.name = name;
        this.types = types;
    }

    public PokeData(byte number, string name, PokeTypes types)
    {
        this.number = number;
        this.name = name;
        this.types = (short)types;
    }

    public string TypesToString()
    {
        string str = "";

        for(int i = 0; i < 16; i++)
        {
            short t =  (short)(types & (1 << i));

            switch (t)
            {
                case (short)PokeTypes.normal :
                    return "Normal";
                
                case (short)PokeTypes.fire :
                    str += "Fire "; 
                    break;
                case (short)PokeTypes.water :
                    str += "Water "; 
                    break;
                case (short)PokeTypes.electric :
                    str += "Electric "; 
                    break;
                case (short)PokeTypes.grass :
                    str += "Grass "; 
                    break;
                case (short)PokeTypes.ice :
                    str += "Ice "; 
                    break;
                case (short)PokeTypes.fighting :
                    str += "Fighting "; 
                    break;
                case (short)PokeTypes.poison :
                    str += "Poison "; 
                    break;
                case (short)PokeTypes.ground :
                    str += "Ground "; 
                    break;
                case (short)PokeTypes.flying :
                    str += "Flying "; 
                    break;
                case (short)PokeTypes.psychic :
                    str += "Psychic "; 
                    break;
                case (short)PokeTypes.bug :
                    str += "Bug "; 
                    break;
                case (short)PokeTypes.rock :
                    str += "Rock "; 
                    break;
                case (short)PokeTypes.ghost :
                    str += "Ghost "; 
                    break;
                case (short)PokeTypes.dragon :
                    str += "Dragon "; 
                    break;
            }
        }

        return str;
    }

    public static PokeData[] pokeData = {
new PokeData(0, "MissingNo" , PokeTypes.flying | PokeTypes.grass ),
new PokeData(1, "Bulbasaur" , PokeTypes.grass | PokeTypes.poison ),
new PokeData(2, "Ivysaur", PokeTypes.grass | PokeTypes.poison ),
new PokeData(3, "Venusaur", PokeTypes.grass | PokeTypes.poison ),
new PokeData(4, "Charmander", PokeTypes.fire ),
new PokeData(5, "Charmeleon", PokeTypes.fire ),
new PokeData(6, "Charizard" , PokeTypes.fire | PokeTypes.flying ),
new PokeData(7, "Squirtle", PokeTypes.water ),
new PokeData(8, "Wartortle", PokeTypes.water ),
new PokeData(9, "Blastoise", PokeTypes.water ),
new PokeData(10, "Caterpie", PokeTypes.bug ),
new PokeData(11, "Metapod", PokeTypes.bug ),
new PokeData(12, "Butterfree", PokeTypes.bug | PokeTypes.flying ),
new PokeData(13, "Weedle", PokeTypes.bug | PokeTypes.poison ),
new PokeData(14, "Kakuna", PokeTypes.bug | PokeTypes.poison ),
new PokeData(15, "Beedrill", PokeTypes.bug | PokeTypes.poison ),
new PokeData(16, "Pidgey", PokeTypes.normal | PokeTypes.flying ),
new PokeData(17, "Pidgeotto", PokeTypes.normal | PokeTypes.flying ),
new PokeData(18, "Pidgeot", PokeTypes.normal | PokeTypes.flying ),
new PokeData(19, "Rattata", PokeTypes.normal ),
new PokeData(20, "Raticate", PokeTypes.normal ),
new PokeData(21, "Spearow", PokeTypes.normal | PokeTypes.flying ),
new PokeData(22, "Fearow", PokeTypes.normal | PokeTypes.flying ),
new PokeData(23, "Ekans", PokeTypes.poison ),
new PokeData(24, "Arbok", PokeTypes.poison ),
new PokeData(25, "Pikachu", PokeTypes.electric ),
new PokeData(26, "Raichu", PokeTypes.electric ),
new PokeData(27, "Sandshrew", PokeTypes.ground ),
new PokeData(28, "Sandslash", PokeTypes.ground ),
new PokeData(29, "Nidoran♀", PokeTypes.poison ),
new PokeData(30, "Nidorina", PokeTypes.poison ),
new PokeData(31, "Nidoqueen", PokeTypes.poison | PokeTypes.ground ),
new PokeData(32, "Nidoran♂", PokeTypes.poison ),
new PokeData(33, "Nidorino", PokeTypes.poison ),
new PokeData(34, "Nidoking", PokeTypes.poison | PokeTypes.ground ),
new PokeData(35, "Clefairy", PokeTypes.normal ),
new PokeData(36, "Clefable", PokeTypes.normal ),
new PokeData(37, "Vulpix", PokeTypes.fire ),
new PokeData(38, "Ninetales", PokeTypes.fire ),
new PokeData(39, "Jigglypuff", PokeTypes.normal ),
new PokeData(40, "Wigglytuff", PokeTypes.normal ),
new PokeData(41, "Zubat", PokeTypes.poison | PokeTypes.flying ),
new PokeData(42, "Golbat", PokeTypes.poison | PokeTypes.flying ),
new PokeData(43, "Oddish", PokeTypes.grass | PokeTypes.poison ),
new PokeData(44, "Gloom", PokeTypes.grass | PokeTypes.poison ),
new PokeData(45, "Vileplume", PokeTypes.grass | PokeTypes.poison ),
new PokeData(46, "Paras", PokeTypes.bug | PokeTypes.grass ),
new PokeData(47, "Parasect", PokeTypes.bug | PokeTypes.grass ),
new PokeData(48, "Venonat", PokeTypes.bug | PokeTypes.poison ),
new PokeData(49, "Venomoth", PokeTypes.bug | PokeTypes.poison ),
new PokeData(50, "Diglett", PokeTypes.ground ),
new PokeData(51, "Dugtrio", PokeTypes.ground ),
new PokeData(52, "Meowth", PokeTypes.normal ),
new PokeData(53, "Persian", PokeTypes.normal ),
new PokeData(54, "Psyduck", PokeTypes.water ),
new PokeData(55, "Golduck", PokeTypes.water ),
new PokeData(56, "Mankey", PokeTypes.fighting ),
new PokeData(57, "Primeape", PokeTypes.fighting ),
new PokeData(58, "Growlithe", PokeTypes.fire ),
new PokeData(59, "Arcanine", PokeTypes.fire ),
new PokeData(60, "Poliwag", PokeTypes.water ),
new PokeData(61, "Poliwhirl", PokeTypes.water ),
new PokeData(62, "Poliwrath", PokeTypes.water | PokeTypes.fighting ),
new PokeData(63, "Abra", PokeTypes.psychic ),
new PokeData(64, "Kadabra", PokeTypes.psychic ),
new PokeData(65, "Alakazam", PokeTypes.psychic ),
new PokeData(66, "Machop", PokeTypes.fighting ),
new PokeData(67, "Machoke", PokeTypes.fighting ),
new PokeData(68, "Machamp", PokeTypes.fighting ),
new PokeData(69, "Bellsprout", PokeTypes.grass | PokeTypes.poison ),
new PokeData(70, "Weepinbell", PokeTypes.grass | PokeTypes.poison ),
new PokeData(71, "Victreebel", PokeTypes.grass | PokeTypes.poison ),
new PokeData(72, "Tentacool", PokeTypes.water | PokeTypes.poison ),
new PokeData(073, "Tentacruel", PokeTypes.water | PokeTypes.poison ),
new PokeData(74, "Geodude", PokeTypes.rock | PokeTypes.ground ),
new PokeData(75, "Graveler", PokeTypes.rock | PokeTypes.ground ),
new PokeData(76, "Golem", PokeTypes.rock | PokeTypes.ground ),
new PokeData(77, "Ponyta", PokeTypes.fire ),
new PokeData(78, "Rapidash", PokeTypes.fire ),
new PokeData(79, "Slowpoke", PokeTypes.water | PokeTypes.psychic ),
new PokeData(80, "Slowbro", PokeTypes.water | PokeTypes.psychic ),
new PokeData(81, "Magnemite", PokeTypes.electric ),
new PokeData(82, "Magneton", PokeTypes.electric ),
new PokeData(83, "Farfetch'd", PokeTypes.normal | PokeTypes.flying ),
new PokeData(84, "Doduo", PokeTypes.normal | PokeTypes.flying ),
new PokeData(85, "Dodrio", PokeTypes.normal | PokeTypes.flying ),
new PokeData(86, "Seel", PokeTypes.water ),
new PokeData(87, "Dewgong", PokeTypes.water | PokeTypes.ice ),
new PokeData(88, "Grimer", PokeTypes.poison ),
new PokeData(89, "Muk", PokeTypes.poison ), 
new PokeData(90, "Shellder", PokeTypes.water ),
new PokeData(91, "Cloyster", PokeTypes.water | PokeTypes.ice ),
new PokeData(92, "Gastly", PokeTypes.ghost | PokeTypes.poison ),
new PokeData(93, "Haunter", PokeTypes.ghost | PokeTypes.poison ),
new PokeData(94, "Gengar", PokeTypes.ghost | PokeTypes.poison ),
new PokeData(95, "Onix", PokeTypes.rock | PokeTypes.ground ),
new PokeData(96, "Drowzee", PokeTypes.psychic ),
new PokeData(97, "Hypno", PokeTypes.psychic ),
new PokeData(98, "Krabby", PokeTypes.water ),
new PokeData(99, "Kingler", PokeTypes.water ),
new PokeData(100, "Voltorb", PokeTypes.electric ),
new PokeData(101, "Electrode", PokeTypes.electric ),
new PokeData(102, "Exeggcute", PokeTypes.grass | PokeTypes.psychic ),
new PokeData(103, "Exeggutor", PokeTypes.grass | PokeTypes.psychic ),
new PokeData(104, "Cubone", PokeTypes.ground ),
new PokeData(105, "Marowak", PokeTypes.ground ),
new PokeData(106, "Hitmonlee", PokeTypes.fighting ),
new PokeData(107, "Hitmonchan", PokeTypes.fighting ),
new PokeData(108, "Lickitung", PokeTypes.normal ),
new PokeData(109, "Koffing", PokeTypes.poison ),
new PokeData(110, "Weezing", PokeTypes.poison ),
new PokeData(111, "Rhyhorn", PokeTypes.ground | PokeTypes.rock ),
new PokeData(112, "Rhydon", PokeTypes.ground | PokeTypes.rock ),
new PokeData(113, "Chansey", PokeTypes.normal ),
new PokeData(114, "Tangela", PokeTypes.grass ),
new PokeData(115, "Kangaskhan", PokeTypes.normal ),
new PokeData(116, "Horsea", PokeTypes.water ),
new PokeData(118, "Goldeen", PokeTypes.water ),
new PokeData(119, "Seaking", PokeTypes.water ),
new PokeData(120, "Staryu", PokeTypes.water ),
new PokeData(121, "Starmie", PokeTypes.water | PokeTypes.psychic ),
new PokeData(122, "Mr. Mime", PokeTypes.psychic ),
new PokeData(123, "Scyther", PokeTypes.bug | PokeTypes.flying ),
new PokeData(124, "Jynx", PokeTypes.ice | PokeTypes.psychic ),
new PokeData(125, "Electabuzz", PokeTypes.electric ),
new PokeData(126, "Magmar", PokeTypes.fire ),
new PokeData(127, "Pinsir", PokeTypes.bug ),
new PokeData(128, "Tauros", PokeTypes.normal ),
new PokeData(129, "Magikarp", PokeTypes.water ),
new PokeData(130, "Gyarados", PokeTypes.water | PokeTypes.flying ),
new PokeData(131, "Lapras", PokeTypes.water | PokeTypes.ice ),
new PokeData(132, "Ditto", PokeTypes.normal ),
new PokeData(133, "Eevee", PokeTypes.normal ),
new PokeData(134, "Vaporeon", PokeTypes.water ),
new PokeData(135, "Jolteon", PokeTypes.electric ),
new PokeData(136, "Flareon", PokeTypes.fire ),
new PokeData(137, "Porygon", PokeTypes.normal ),
new PokeData(138, "Omanyte", PokeTypes.rock | PokeTypes.water ),
new PokeData(139, "Omastar", PokeTypes.rock | PokeTypes.water ),
new PokeData(140, "Kabuto", PokeTypes.rock | PokeTypes.water ),
new PokeData(141, "Kabutops", PokeTypes.rock | PokeTypes.water ),
new PokeData(142, "Aerodactyl", PokeTypes.rock | PokeTypes.flying ),
new PokeData(143, "Snorlax", PokeTypes.normal ),
new PokeData(144, "Articuno", PokeTypes.ice | PokeTypes.flying ),
new PokeData(145, "Zapdos", PokeTypes.electric | PokeTypes.flying ),
new PokeData(146, "Moltres", PokeTypes.fire | PokeTypes.flying ),
new PokeData(147, "Dratini", PokeTypes.dragon ),
new PokeData(148, "Dragonair", PokeTypes.dragon ),
new PokeData(149, "Dragonite", PokeTypes.dragon | PokeTypes.flying ),
new PokeData(150, "Mewtwo", PokeTypes.psychic ),
new PokeData(151, "Mew", PokeTypes.psychic )
};

}