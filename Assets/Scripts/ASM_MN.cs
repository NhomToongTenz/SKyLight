using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
using System.Threading;
using Unity.VisualScripting.Dependencies.NCalc;

public class ASM_MN : Singleton<ASM_MN>
{
    public List<Region> listRegion = new List<Region>();
    List<Players> listPlayer = new List<Players>();

    
    
    
    
    private void Start()
    {
        createRegion();
        add5Players();
    }
    
    // add 5 players
    public void add5Players()
    {
        listPlayer.Add(new Players(0, "Player 1", 100, 0));
        listPlayer.Add(new Players(1, "Player 2", 200, 1));
        listPlayer.Add(new Players(2, "Player 3", 500, 2));
        listPlayer.Add(new Players(3, "Player 4", 900, 3));
        listPlayer.Add(new Players(4, "Player 5", 1000, 4));
    }
    
    

    public void createRegion()
    {
        listRegion.Add(new Region(0, "VN"));
        listRegion.Add(new Region(1, "VN1"));
        listRegion.Add(new Region(2, "VN2"));
        listRegion.Add(new Region(3, "JS"));
        listRegion.Add(new Region(4, "VS"));
    }

    
    public enum Rank
    {
        Bronze,
        Silver,
        Gold,
        Platinum,
        Diamond,
        Master,
        GrandMaster
        
    }
    
    public string calculate_rank(int score)
    {
        // sinh viên viết tiếp code ở đây
        switch (score)
        {
            case < 100:
                return Rank.Bronze.ToString();
            case < 500:
                return Rank.Silver.ToString();
            case < 1000:
                return Rank.Gold.ToString();
            case >= 1000:
                return Rank.Diamond.ToString();
        }
        //return null;
    }

    public void YC1(int _id, string _name, int _score, int _regionID)
    {
        // sinh viên viết tiếp code ở đây
        
        Players existPlayer = listPlayer.FirstOrDefault(x => x.getID() == _id);

        if (existPlayer != null)
        {
            existPlayer.setScore(_score);
            Debug.Log("Update player");
        }
        else
        {
            listPlayer.Add(new Players(_id, _name, _score, _regionID));
            Debug.Log("Add new player");
        }
        
    }
    public void YC2()
    {
        // sinh viên viết tiếp code ở đây
        // display list player
        foreach (var player in listPlayer)
        {
            Debug.Log("ID: " + player.getID() + 
					" Name: " + player.getName() + 
					" Score: " + player.getScore() + 
					" RegionID: " + player.getRegionID() + 
					" Rank: " + player.rank);
        }
    }
    public void YC3()
    {
        // sinh viên viết tiếp code ở đây
    }
    public void YC4()
    {
        // sinh viên viết tiếp code ở đây
    }
    public void YC5()
    {
        // sinh viên viết tiếp code ở đây
    }
    public void YC6()
    {
        // sinh viên viết tiếp code ở đây
    }
    public void YC7()
    {
        // sinh viên viết tiếp code ở đây
    }
    void CalculateAndSaveAverageScoreByRegion()
    {
        // sinh viên viết tiếp code ở đây
    }
    
    public List<Players> GetListPlayer()
    {
        // sinh viên viết tiếp code ở đây
        return listPlayer;
    }

}

[SerializeField]
public class Region
{
    public int ID;
    public string Name;
    public Region(int ID, string Name)
    {
        this.ID = ID;
        this.Name = Name;
    }
}

[SerializeField]
public class Players
{
    // sinh viên viết tiếp code ở đây
    private int id;
    private string name;
    private int score;
    private int regionID;
    public string rank {get {return ASM_MN.Instance.calculate_rank(score);}}
    
    public Players(int id, string name, int score, int regionID)
    {
        this.id = id;
        this.name = name;
        this.score = score;
        this.regionID = regionID;
    }
    
    #region Getters and Setters
    
    public int getID()
    {
        return id;
    }
    
    public string getName()
    {
        return name;
    }
    
    public int getScore()
    {
        return score;
    }
    
    public int getRegionID()
    {
        return regionID;
    }
    
    public void setID(int id)
    {
        this.id = id;
    }
    
    public void setName(string name)
    {
        this.name = name;
    }
    
    public void setScore(int score)
    {
        this.score = score;
    }
    
    #endregion
    
    
}