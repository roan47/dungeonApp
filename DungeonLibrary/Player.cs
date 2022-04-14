﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //Make this class public & inherit from Character
    public class Player : Character
    {
        //The fields and properties for Character have all
        //been inherited, so we only need the properties
        //unique to a Player here.

        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }

        //Fully qualified constructor that inherits assignment from Character
        public Player(string name, int hitChance, int block, int life, int maxLife, Race characterRace,
            Weapon equippedWeapon) : base(name, hitChance, block, maxLife, life)
        {
            //Assignment of unique properties
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;

            #region Potential Expansion - Racial Bonuses

            //switch (CharacterRace)
            //{
            //    case Race.Elf:
            //        HitChance += 5;
            //        break;
            //}

            #endregion
        }

        //override the ToString()
        public override string ToString()
        {
            //Holding variable for Player's race info
            string description = "";

            //Depending on the race, update the string
            switch (CharacterRace)
            {
                case Race.Ren:
                    description = "fool persona";
                    break;
                case Race.Morgana:
                    description = "Magician persona";
                    break;
                case Race.Ryujii:
                    description = "Chariot persona";
                    break;
                case Race.Yusuke:
                    description = "Emperor persona";
                    break;
                case Race.Makoto:
                    description = "Priestess persona.";
                    break;
                case Race.Akechi:
                    description = "Justice persona";
                    break;
                case Race.Yoshizawa:
                    description = "Faith persona";
                    break;
                case Race.Haru:
                    description = "Empress persona";
                    break;
            }

            //return the formatted string with all related info
            return string.Format("-=-= {0} =-=-\n" +
                "Life: {1} of {2}\nHit Chance: {3}%\n" +
                "Weapon:\n{4}\nBlock: {5}\nDescription: {6}",
                Name,
                Life,
                MaxLife,
                HitChance,
                //CalcHitChance(),
                EquippedWeapon,
                Block,
                description);
        }

        //override Character's CalcDamage() to use the Player's EquippedWeapon
        public override int CalcDamage()
        {
            //create a random object
            Random rand = new Random();

            //determine damage
            int damage = rand.Next(EquippedWeapon.MinDamage,
                EquippedWeapon.MaxDamage + 1);

            //return damage
            return damage;
        }

        //override Character's CalcHitChance to use the Player's EquippedWeapon
        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }
    }
}
