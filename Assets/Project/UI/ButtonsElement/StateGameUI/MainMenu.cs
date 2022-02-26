using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class MainMenu : MonoBehaviour
{
    public Button MainMenuGame=>_mainMenuGame;
    [SerializeField] private Button _mainMenuGame;
    public void Show()
    {
        _mainMenuGame.gameObject.SetActive(true);
    }
    public void Close()
    {
        _mainMenuGame.gameObject.SetActive(false);
    }
}
