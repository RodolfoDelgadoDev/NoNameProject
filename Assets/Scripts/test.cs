using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class test : MonoBehaviour
{

    public string inputline;
    // Start is called before the first frame update
    void Start()
    {
        InputDecoder.CharacterList.Add(new Character("M", "Coffee", Color.green, "Falopa.mp3"));
        inputline = "Character(a, Alfonso, color=red, image=jadsj.jpg)";
        InputDecoder.ParseInput(inputline);

        inputline = "a \"todas trolas\"";
        InputDecoder.ParseInput(inputline);

        inputline = "show Sonic";
        InputDecoder.ParseInput(inputline);

    

    }

}
