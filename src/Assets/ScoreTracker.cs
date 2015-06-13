using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    private static float _bestScore;
    private float _score;

    private Text _scoreText;
    private Text _bestScoreText;

    // Use this for initialization
    void Start()
    {
        _scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        _bestScoreText = GameObject.Find("BestScoreText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Body") != null)
        {
            _score += Time.deltaTime;

            _bestScore = Mathf.Max(_score, _bestScore);
        }

        _scoreText.text = "Score: " + ((int)_score);
        _bestScoreText.text = "Best score: " + (int)_bestScore;
    }
}
