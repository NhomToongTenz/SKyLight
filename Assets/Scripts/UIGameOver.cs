using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI userName;
    ScoreKeeper scoreKeeper;
    ASM_MN ASM_MN;

    void Awake()
    {  
       scoreKeeper = ScoreKeeper.Instance;
       ASM_MN = ASM_MN.Instance;
    }

    void Start()
    {	
		
		
         
        scoreText.text = "You Scored:\n" + scoreKeeper.GetScore();
        userName.text = "Your Rank: " + ASM_MN.calculate_rank(scoreKeeper.GetScore()) + "\n" + scoreKeeper.GetUserName();
        
        ASM_MN.YC1(scoreKeeper.GetID(), scoreKeeper.GetUserName(), scoreKeeper.GetScore(), scoreKeeper.GetIDregion());
        
        //DisPlayListPlayer();
        ASM_MN.YC2();
    }
    
    
    
    
    
    
   
    


}
