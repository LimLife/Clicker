using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Pause : MonoBehaviour
{
    public Button PauseGame => _pauseGame;
    [SerializeField] private Button _pauseGame;
    public void Show()
    {
        _pauseGame.gameObject.SetActive(true);
    }
    public void Close()
    {
        _pauseGame.gameObject.SetActive(false);
    }
}
