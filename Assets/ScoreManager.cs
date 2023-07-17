using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    int _deathCount = 0;

    public static ScoreManager Instance { get; private set; }
    
    private void Awake()
    {
        Instance = this;
    }

    internal void AddScore(int count)
    {
        _deathCount += count;
        Debug.Log($" Death count : {_deathCount}");
    }


}
