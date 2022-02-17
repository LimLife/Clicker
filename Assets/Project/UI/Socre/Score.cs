using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _score;
    
    public void AddScoreValue(float score)
    {       
        _score.text = $"Socre: {score:0.0}";        
    }
}
