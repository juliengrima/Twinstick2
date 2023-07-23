using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    int _score = 0;
    int score;
    [SerializeField] TextMeshProUGUI _scoreText;

    public static ScoreManager Instance { get; private set; }
    
    private void Awake()
    {
        Instance = this;
    }

    internal void AddScore(int amount)
    {
        _score += amount;
        _score = score;
        _scoreText.text = _score.ToString();
        //Debug.Log($" Death count : {_score}");
    }

    internal void DeleteScore(int amount)
    {
        _score -= amount;
        _scoreText.text = _score.ToString();
       
        //Debug.Log($" PlayerDeath count : {_score}");
    }

}
