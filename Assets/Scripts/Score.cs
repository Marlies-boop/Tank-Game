using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int Player1Score = 0;
    public int Player2Score = 0;
    public Text Textp1;
    public Text Textp2;

    public void AddP1Score()
    {
        Player1Score++;
        Textp1.text = Player1Score.ToString();
    }

    public void AddP2Score()
    {
        Player2Score++;
        Textp2.text = Player2Score.ToString();
    }

}
