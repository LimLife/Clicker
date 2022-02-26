using UnityEngine.UI;
using UnityEngine;

public class TimeUIGame : MonoBehaviour
{
    [SerializeField] private Text _timer;
    private string _textDiscripron = "Time: ";
    public void SetTime(float time)
    {
        _timer.text = _textDiscripron + time;
    }
}
