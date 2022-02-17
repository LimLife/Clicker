using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private GameSystemHandler _manager;
    [SerializeField] private UIHandler _uIHandler;
    private Mediator _mediator;
    private bool _isPause;
    private void Awake()
    {
        _mediator = new Mediator();
        _manager.Init(_mediator);
        _uIHandler.Init(_mediator);
        _mediator.Init(_uIHandler, _manager);
        Subscribe();
    }
    private void Lose()
    {
        Instance.Singleton.AddScore((int)_manager.Score); //Исправить сохороняемые значения
        Instance.Singleton.Save();
        UnSubscribe();
    }
    private void Subscribe()
    {
        _uIHandler.Lose += Lose;
        _uIHandler.ButtonPauseEvent += OnPauseGame;
    }
   
    private void OnPauseGame(bool isPause)
    {
        _isPause = isPause;
        _manager.Pause(_isPause);
    }

    private void UnSubscribe()
    {
        _uIHandler.UnSubscribe();     
        _uIHandler.Lose -= Lose;
    }
}
