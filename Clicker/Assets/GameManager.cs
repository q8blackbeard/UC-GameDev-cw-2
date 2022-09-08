using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public int price;
    int inc = 1;
   int score = 0;
    public Text countertext;
    public Text inctext ;
    public Text Errortext;
    public Text pricetext;

    public void IncreaseScore() {
        
        score+= inc; 
         countertext.text = score.ToString();

        
       
    
    
    }
    public void shop()
    {

        if (score > price * inc)
        {
            score -= price * inc;
            countertext.text = score.ToString();
            inc += 1;
            inctext.text = "inc: " + inc;
            pricetext.text = "Price = " + (price * inc);
            Errortext.text = "";

        }
        else
        {
            Errortext.text = "you don't have enough Score!";
        }
    }
}
