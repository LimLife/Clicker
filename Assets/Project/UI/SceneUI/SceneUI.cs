using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneUI : MonoBehaviour
{
    public event Action<bool> IsPauseEvent;

    [SerializeField] private MainMenu _mainMenu;
    [SerializeField] private Restart _restart;
    [SerializeField] private Pause _pause;
    [SerializeField] private StartGame _startGame;
    [SerializeField] private Blocker _blocker;

    private bool _isPause = true;



    public void Init()
    {
        Subscribe();
        _restart.Close();
        _mainMenu.Close();
        _startGame.Show();       
    }


    public void OnLoseMenu()
    {
        _restart.Show();
        _mainMenu.Show();
        _blocker.Show();
    }

    private void Subscribe()
    {
        StartGame();
        RestartGame();
        PauseGame();
        ManiMenuGame();
    }
    private void StartGame()
    {
        Time.timeScale = StringTag.PAUSE;
        _startGame.StartButton.onClick.AddListener(() =>
        {
            Time.timeScale = StringTag.UN_PAUSE;
            _startGame.Close();
        });
    }
    private void RestartGame()
    {
        _restart.RestartGame.onClick.AddListener(() =>
        {
            UnSubscribe();
            SceneManager.LoadScene(StringTag.GameScene);
        });
    }
    private void PauseGame()
    {
        _pause.PauseGame.onClick.AddListener(() =>
        {
            if (_isPause == false)
            {
                _blocker.Show();
                Time.timeScale = StringTag.PAUSE;
                _isPause = true;
                IsPauseEvent?.Invoke(true);
            }
            else
            {
                Time.timeScale = StringTag.UN_PAUSE;
                _blocker.Close();
                _isPause = false;
                IsPauseEvent?.Invoke(false);
            }
        });
    }
    private void ManiMenuGame()
    {
        _mainMenu.MainMenuGame.onClick.AddListener(() =>
        {
            UnSubscribe();
            SceneManager.LoadScene(StringTag.MainMenuScene);
        });
    }

    private void UnSubscribe()
    {
        _startGame.StartButton.onClick.RemoveListener(() => StartGame());
        _restart.RestartGame.onClick.RemoveListener(() => RestartGame());
        _pause.PauseGame.onClick.RemoveListener(() => PauseGame());
        _mainMenu.MainMenuGame.onClick.RemoveListener(() => ManiMenuGame());

    }
}
