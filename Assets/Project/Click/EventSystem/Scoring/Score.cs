using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _score;
    private string _discription = "Score: ";
    public void AddScoreValue(float score)
    {
        _score.text = _discription + score;
    }
}
