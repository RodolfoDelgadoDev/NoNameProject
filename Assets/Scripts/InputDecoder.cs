using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;
using System.Text.RegularExpressions;

/// <summary>
/// InputDecoder class that defines the input of the characters
/// where parses the text and split all the text
/// </summary>
public class InputDecoder : MonoBehaviour
{
    /// <summary>
    /// variable where gets a list of characters
    /// </summary>
    public static List<Character> CharacterList = new List<Character>();

    public Image sonicporfavoraparececonchudo;

    private static GameObject BackGround = GameObject.Find("BackGround");

    private static Image BackgroundImage = BackGround.GetComponent<Image>();

    /// <summary>
    /// ParseInput function where parse the text, removes symbols to say after this
    /// </summary>
    /// <param name="stringToParse">string to parse</param>
    public static void ParseInput(string stringToParse)
    {
        string withoutTabs = stringToParse.Replace("\t", "");
        stringToParse = withoutTabs;
        if(stringToParse.StartsWith("\""))
        {
            Say(stringToParse);
        }
        string[] sepString = { " ", "'", "\"", "(", ")" };
        string[] args = stringToParse.Split(sepString, StringSplitOptions.RemoveEmptyEntries);

        foreach(var arg in args)
        {
            Debug.Log(arg);
        }

        foreach(Character character in CharacterList)
        {
            if (args[0] == character.name)
                SplitToSay(stringToParse, character);
        }

        if (args[0] == "show")
        {
            showImage(stringToParse);
        }

        if (args[0] == "clearScr")
        {
            ClearScreen();
        }

    }


    /// <summary>
    /// Function where Splits all the text after "\" symbol
    /// </summary>
    /// <param name="stringToParse">parsed string</param>
    /// <param name="character">name of the character</param>
    public static void SplitToSay(string stringToParse, Character character)
    {
        int toQuote = stringToParse.IndexOf("\"") + 1;
        int endQuote = stringToParse.Length - 1;
        string stringToOutput = stringToParse.Substring(toQuote, endQuote - toQuote);
        Say(character.longName, stringToOutput);

        
    }

    /// <summary>
    /// Say function to say only a thing
    /// </summary>
    /// <param name="what">who said it</param>
    public static void Say(string what)
    {
        Debug.Log(what);
    }

    /// <summary>
    /// Say function to show who said certain thing
    /// </summary>
    /// <param name="who">character</param>
    /// <param name="what">what says</param>
    public static void Say(string who, string what)
    {
        Debug.Log(who + ": " + what);
    }



    public static void showImage(string stringtoparse)
    {
        var ImageToUse = new Regex(@"show (?<ImageFileName>[^.]+)");
        var matches = ImageToUse.Match(stringtoparse);
        string ImageToShow = matches.Groups["ImageFileName"].ToString();
        Debug.Log(ImageToShow);
        BackgroundImage.sprite = Resources.Load<Sprite>("Images/BackGrounds/" + ImageToShow);
    }

    public static void ClearScreen()
    {
        BackgroundImage.sprite = null;
    }
}
