using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
    public int playScore;
    public Text scoreText;


    //[ContextMenu(" Increase Score")]
    //public void addScore(int scoreToAdd)
    //{
    // playScore = playScore + scoreToAdd;
    // scoreText.text = playScore.ToString();
    //}
    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playScore = playScore + 1;
        scoreText.text = playScore.ToString();

    }
}

    

