using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIDisplay : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] Slider healthSlider;
    [SerializeField] Health playerHealth;

    [Header("Score")]
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreKeeper scoreKeeper;
    
    [Header("User")]
    [SerializeField] TextMeshProUGUI userName;

    void Awake()
    {
        scoreKeeper = ScoreKeeper.Instance;
    }

    void Start()
    {
        healthSlider.maxValue = playerHealth.GetHealth();
        
        userName.text = "Player : " + scoreKeeper.GetUserName();
    }

    void Update()
    {
        healthSlider.value = playerHealth.GetHealth();
        scoreText.text = scoreKeeper.GetScore().ToString("000000000");
    }
}
