using UnityEngine;
public class DataBase
{
    public int Score { get; set; }
    public int LoadData()
    {
        return  PlayerPrefs.GetInt(StringTag.TopScore, 0);
    }
    public void SaveData()
    {
        PlayerPrefs.SetInt(StringTag.TopScore, Score);
    }
}
