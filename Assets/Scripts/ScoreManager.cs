using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;
    private int score = 0;
    private int highscore = 0;

    void Start()
    {
        highscore = PlayerPrefs.GetInt("Highscore", 0);
        UpdateHighscoreText();
        StartCoroutine(UpdateScore());
    }

    IEnumerator UpdateScore()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            score++;
            CheckForHighscore();
            UpdateScoreText();
            
        }
    }

    void CheckForHighscore()
    {
        if(score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("Highscore", highscore);
            UpdateHighscoreText();
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }

    void UpdateHighscoreText()
    {
        highscoreText.text = highscore.ToString();
    }
}
