using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class BattleHud : MonoBehaviour
{

//int Name text fields Start
    [SerializeField] Text Player1NameText; 
    [SerializeField] Text Player1HPText; 
    [SerializeField] Text Player2NameText; 
    [SerializeField] Text Player2HPText; 
    [SerializeField] Text Player3NameText; 
    [SerializeField] Text Player3HPText; 
    [SerializeField] Text Player4NameText; 
    [SerializeField] Text Player4HPText; 
    [SerializeField] Text Enemy1NameText; 
    [SerializeField] Text Enemy2NameText;
    [SerializeField] Text Enemy3NameText; 
//int Name text fields End

//Action and Move Select 
[SerializeField] GameObject actionSelector; 
[SerializeField] GameObject moveSelector; 
[SerializeField] GameObject moveDetails;
[SerializeField] GameObject notificationBox;
[SerializeField] List<Text> actionTexts; 
[SerializeField] List<Text> moveTexts; 
[SerializeField] Text movecostText; 
[SerializeField] Text movedetailsText; 
//Action and Move Select End
[SerializeField] Color highlightedColor;

Char _char; 


//VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV
    public void SetDataPlayer1(Char Char)
    {
         _char = Char;

        Player1NameText.text = Char.Base.Name;
        Player1HPText.text = ($"{Char.CurrentHP}/{Char.MaxHP}"); 
        // levelText.text = "Level " + Char.Level;
    }
        public void SetDataPlayer2(Char Char)
    {
        Player2NameText.text = Char.Base.Name;
        Player2HPText.text = ($"{Char.CurrentHP}/{Char.MaxHP}"); 
        // levelText.text = "Level " + Char.Level;
    }
        public void SetDataPlayer3(Char Char)
    {
        Player3NameText.text = Char.Base.Name;
        Player3HPText.text = ($"{Char.CurrentHP}/{Char.MaxHP}");  
        // levelText.text = "Level " + Char.Level;
    }
        public void SetDataPlayer4(Char Char)
    {
        Player4NameText.text = Char.Base.Name;
        Player4HPText.text = ($"{Char.CurrentHP}/{Char.MaxHP}"); 
        // levelText.text = "Level " + Char.Level;
    }
public void SetDataEnemy1(Char Char)
    {
        Enemy1NameText.text = Char.Base.Name;
    }
public void SetDataEnemy2(Char Char)
    {
        Enemy2NameText.text = Char.Base.Name;
       // ATKText.text = "ATK " + Char.Strength;
    }
    public void SetDataEnemy3(Char Char)
    {
        Enemy3NameText.text = Char.Base.Name;
       // ATKText.text = "ATK " + Char.Strength;
    }
//VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV


    public void UpdateHP()
    {
        Player1HPText.text = ($"{_char.CurrentHP}/{_char.MaxHP}"); 
    }



    public void EnableNotificationText(bool enabled)
    {
        notificationBox.SetActive(enabled);
    }
    public void EnableActionSelector(bool enabled)
    {
    actionSelector.SetActive(enabled);
    }
    public void EnableMoveSelector(bool enabled)
    {
    moveSelector.SetActive(enabled);
    moveDetails.SetActive(enabled);
    
    }

    public void UpdateActionSelection(int selectedAction) 
    {
        for (int i=0; i<actionTexts.Count; ++i)
            {
                if (i == selectedAction)
                actionTexts[i].color = highlightedColor;
                else
                    actionTexts[i].color = Color.black;
            }
    }  
    public void UpdateMoveSelection(int selectedMove, CharMove move) 
    {
        for (int i=0; i<moveTexts.Count; ++i)
            {
                if (i == selectedMove)
                moveTexts[i].color = highlightedColor;
                else
                    moveTexts[i].color = Color.black;
            }
        movedetailsText.text = move.Base.Description;
        movecostText.text = $"{move.Base.MoveCost}/{move.MOVECOST}";
    }      
    
    public void SetMoveNames(List<CharMove> moves)
    {
        for (int i=0; i<moveTexts.Count; ++i)
        {
            if (i < moves.Count)
                moveTexts[i].text = moves[i].Base.CharMoveName;
            else
                moveTexts[i].text = "-";

        }
    }
}

