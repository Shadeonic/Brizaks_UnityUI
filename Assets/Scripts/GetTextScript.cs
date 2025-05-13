using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTextScript : MonoBehaviour
{
    string playerName;
    string playerAge;
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
        playerAge = inputFieldA.GetComponent<Text>().text;
        bool isNumber = int.TryParse(playerAge, out int intAge);
        if(!isNumber || intAge>2025 || intAge<1900 || playerName.Length==0){
            TextField.GetComponent<Text>().text = "Nekorekti ievadīts gads un/vai vārds!";
        }
        else{
            TextField.GetComponent<Text>().text = textArray[randText] + " "+ playerName+" ir "+(2025-intAge) + " gadu(s) vecs!";
        }
    }
}
