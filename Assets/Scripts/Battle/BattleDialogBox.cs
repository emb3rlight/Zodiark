using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BattleDialogBox : MonoBehaviour
{

[SerializeField] Text dialogText;
[SerializeField] int lettersPerSecond; 

//Sets Dialog text
    public void SetDialog(string dialog) 
    {
    dialogText.text = dialog;
    }

//Loops text to diasplay slowly on encounter
    public IEnumerator TypeDialog(string dialog)
    {
    dialogText.text = "";
    foreach (var letter in dialog.ToCharArray())
    {
        dialogText.text += letter;
        yield return new WaitForSeconds(1f/lettersPerSecond);
    }
    }


}
