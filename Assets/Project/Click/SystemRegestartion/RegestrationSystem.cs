using System.Collections.Generic;

public class RegestrationSystem
{
    public List<ISystem> Moduls => _moduls;
    private List<ISystem> _moduls;

    public List<IEventSystem> EventModuls => _eventModuls;
    private List<IEventSystem> _eventModuls;
    private Spawner _spawner;
    private readonly DataSystem _data;
    private ViewUIGame _viewGame;
    private GameTime _time;
    public RegestrationSystem(Spawner spawner, DataSystem data, ViewUIGame viewGame, GameTime time)
    {
        _moduls = new List<ISystem>();
        _eventModuls = new List<IEventSystem>();
        _data = data;
        _spawner = spawner;
        _viewGame = viewGame;
        _time = time;
        EventSystem();
        Regestration();
        InitSystsems();
    }
    private void Regestration()
    {
        _moduls.Add(new ClickInput(_data));
        _moduls.Add(new FindObject(_data));
        _moduls.Add(new GameTimeUI(_time, _data, _viewGame));//много ссылок     
    }

    private void EventSystem()
    {
        _eventModuls.Add(new Scoring(_data));
        _eventModuls.Add(new ScoreView(_data, _viewGame));
    }
    private void InitSystsems()
    {
        _spawner.Init(_data);
    }
}
