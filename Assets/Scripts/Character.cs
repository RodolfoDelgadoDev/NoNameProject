using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    public string longName;
    public Color color;
    public string characterImage;

    public Character(string charName, string charFullname, Color charColor, string charImage)
    {
        this.name = charName;
        this.longName = charFullname;
        this.color = charColor;
        this.characterImage = charImage;
    }
}
