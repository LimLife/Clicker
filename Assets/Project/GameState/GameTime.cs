using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class GameTime : MonoBehaviour
{
    public event Action TimeUp;

    [SerializeField] private Text _timeGame;
    private float _timeRemainding = 5f;
    private WaitForSeconds _seconds;

    public void Init()
    {
        _seconds = new WaitForSeconds(0.1f);
        StartCoroutine(Сountdown());
    }

    public void AddRemainingTime(float time)
    {
        _timeRemainding += time;
    }

    private IEnumerator Сountdown()
    {
        while (_timeRemainding >= 0)
        {
            yield return _seconds;

            _timeRemainding -= 0.1f;
            _timeGame.text = $"TimeLeft: {_timeRemainding:0.0}";

        }
        TimeUp?.Invoke();
        yield break;
    }
}
