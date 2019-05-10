using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] 
public class PlayerData
{
    public int health;
    public string level;

    public PlayerData(CharacterMov player)
    {
        health = player.getHealth();
        level = player.currLevel;
    }
}
