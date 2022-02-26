using UnityEngine;
public class GameTimeUI : ISystem
{
    public bool TimeUp { get; private set; }
    private ViewUIGame _view;

    private GameTime _gameTime;
    private DataSystem _data;
    private float _timeRamaining;

    private float _oneSeceond;
    public GameTimeUI(GameTime time, DataSystem data, ViewUIGame view)
    {
        _gameTime = time;
        _data = data;
        _view = view;
        _timeRamaining = _gameTime.LifeTimeGame;
    }
    public void Execute()
    {
        if (_timeRamaining == 0)
        {
            return;
        }
        var deltaTime = Time.deltaTime;
        _oneSeceond += deltaTime;

        if (_oneSeceond >= 1f)
        {
            _oneSeceond -= 1;
            _timeRamaining -= 1;
            SetTime();
        }
    }

    public void SetTime()
    {
        _view.SetTime(_timeRamaining);
        if (_timeRamaining <= 0)
        {
            _data.TimeUp(this);
        }
    }

}
