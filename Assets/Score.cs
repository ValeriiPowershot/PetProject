using System;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    
    public int ScoreCount;

    private void Update()
    {
        _scoreText.text = ScoreCount.ToString();
    }
}
