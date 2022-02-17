using UnityEngine;
public class Rank
{
    public void SetTopRank(int score)
    {
        PlayerPrefs.SetInt(StringTag.TopScore,score);
    }
}
