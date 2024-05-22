using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Threading;
using System.IO;

public class ScoreKeeper : Singleton<ScoreKeeper>
{
    private int ID;
    private int score;
    private string userName;
    private int IDregion;


    public int GetID()
    {
        return ID;
    }
    public string GetUserName()
    {
        return userName;
    }

    public int GetScore()
    {
        return score;
    }
    public int GetIDregion()
    {
        return IDregion;
    }
    
    public void SetID(int ID)
    {
        this.ID = ID;
    }
    
    public void SetUserName(string userName)
    {
        if(userName != null)
          this.userName = userName;
        else
            this.userName = "Guest";
       
    }
    
    public void SetScore(int score)
    {
        this.score = score;
    }
    
    public void SetIDregion(int IDregion)
    {
        this.IDregion = IDregion;
    }
    
    

    public void ModifyScore(int value)
    {
        score += value;
        Mathf.Clamp(score, 0, int.MaxValue);
    }

    public void ResetScore(string userName, int IDregion)
    {
        score = 0;
        this.ID = Random.Range(0,19999);
        this.userName = userName;
        this.IDregion = IDregion;
    }

    public void ResetScore(string userName, int IDregion, int id)
    {
        score = 0;
        this.ID = id;
        this.userName = userName;
        this.IDregion = IDregion;
    }


    
    
}
