using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    public Color color;
    public string characterImage;

    public Character(string charName, Color charColor, string charImage)
    {
        this.name = charName;
        this.color = charColor;
        this.characterImage = charImage;
    }
}
