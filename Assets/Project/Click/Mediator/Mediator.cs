using UnityEngine;
public class Mediator :IMediator
{
    public IEntity _uiHandler { get; set; }
    public IEntity _gameHamdler { get; set; }

    public void Init(UIHandler uI, GameSystemHandler game)
    {
        _uiHandler = uI;
        _gameHamdler = game;

    }
    public void Send(IEntity entity,in ClickData data) //Game===>UI
    {
        if (_gameHamdler == entity)
        {
            _uiHandler.Notify(data);           
        }
    }  
}
