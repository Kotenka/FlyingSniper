using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int Score;
    public Text ScoreText;
   public void AddScore()
    {
        Score++;
        ScoreText.text = "Score: " + Score.ToString();
    }




//    public static int scoreValue = 0;
//    Text score;

//    void Start()
//    {
//        score = GetComponent<Text>();
//    }

//    void Update()
//    {
//        score.text = "SCORE: " + scoreValue;
//    }
}