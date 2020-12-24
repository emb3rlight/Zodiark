using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NotificationBox : MonoBehaviour
{

[SerializeField] Text notificationText;
[SerializeField]int lettersPerSecond; 

//Sets Dialog text
public void SetDialog(string dialog) 
{
    notificationText.text = dialog;
}

//Loops text to diasplay slowly on encounter
public IEnumerator TypeDialog(string dialog)
{
    notificationText.text = "";
    foreach (var letter in dialog.ToCharArray())
    {
        notificationText.text += letter;
        yield return new WaitForSeconds(1f/lettersPerSecond);
    }
}


}
