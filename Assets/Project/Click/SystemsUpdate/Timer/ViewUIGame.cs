using UnityEngine;

public class ViewUIGame : MonoBehaviour
{
    [SerializeField] private Score _score;
    [SerializeField] private TimeUIGame _timer;
    public void SetScore(float score)
    {
        _score.AddScoreValue(score);
    }
    public void SetTime(float time)
    {
        _timer.SetTime(time);
    }
}
