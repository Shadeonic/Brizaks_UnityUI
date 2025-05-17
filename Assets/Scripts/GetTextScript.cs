using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTextScript : MonoBehaviour
{
    string playerName;
    int intAge;
    public string[] textArray = {"Terraria tēls ", "Spēlētājs ", "Varonis "};
    int randText;
    public GameObject inputFieldN;
    public GameObject inputFieldA;
    public GameObject TextField;

    public void ShowText()
    {
        randText = Random.Range(0, textArray.Length);
        playerName = inputFieldN.GetComponent<Text>().text;
        if (!string.IsNullOrEmpty(inputFieldA.GetComponent<Text>().text)){
        intAge = int.Parse(inputFieldA.GetComponent<Text>().text);
        if (intAge>2025 || intAge<1900 || playerName.Length==0){
            TextField.GetComponent<Text>().text = "Invalid player name or year!";
        }
        else{
            TextField.GetComponent<Text>().text = textArray[randText] + " "+ playerName+" ir "+(2025-intAge) + " gadu(s) vecs!";
        }
        }else{
            TextField.GetComponent<Text>().text = "Invalid player name or year!";
        }
    }
}
