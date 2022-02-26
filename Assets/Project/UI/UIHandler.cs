using System;
using UnityEngine;

public class UIHandler : MonoBehaviour, IEntity
{

    public event Action Lose;
    public event Action<bool> ButtonPauseEvent;

   // [SerializeField] private Score _score;
    [SerializeField] private GameTimeUI _timer;
    [SerializeField] private SceneUI _sceneUI;

    public IMediator _mediator { get; private set; }

    public void Init(IMediator mediator)
    {
        _mediator = mediator;
      
        _sceneUI.Init();
        Subscribe();
    }
    public void Notify(ClickData data)
    {
        UpdateUI(data);
    }

    private void UpdateUI(ClickData data)
    {
        //_score.AddScoreValue(data.Score);
       
    }
    public void UnSubscribe()
    {
       
        _sceneUI.IsPauseEvent -= OnPause;
        ShowLoseMenu();
    }
    private void Subscribe()
    {
       
        _sceneUI.IsPauseEvent += OnPause;
    }
    private void OnPause(bool pause)
    {
        ButtonPauseEvent?.Invoke(pause);
    }
    private void OnTimeUp()
    {
        Lose?.Invoke();
    }
    private void ShowLoseMenu()
    {
        _sceneUI.OnLoseMenu();
    }



}
