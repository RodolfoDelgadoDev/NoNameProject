using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class test : MonoBehaviour
{

    public string inputline;
    // Start is called before the first frame update
    void Start()
    {
        InputDecoder.CharacterList.Add(new Character("M", "Marcelo", Color.green, "Falopa.mp3"));
        inputline = "M \"todas trolas\"";
        InputDecoder.ParseInput(inputline);

        inputline = "show Sonic";
        Debug.Log("AHORA QUIERO DECIR ESTO: " + inputline);
        InputDecoder.ParseInput(inputline);

    

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
