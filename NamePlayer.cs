using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NamePlayer : MonoBehaviour
{
    public GameManager GameManager;
    public InputField inputField;
    public void NameCharacter()
    {
        GameManager.charName = inputField.text;
        if (GameManager.charName == "")
        {
            GameManager.charName = "Nameless";
        }
    }
}
