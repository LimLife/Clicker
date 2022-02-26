using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Restart : MonoBehaviour
{
    public Button RestartGame => _restartGame;
    [SerializeField] private Button _restartGame;
    public void Show()
    {
        _restartGame.gameObject.SetActive(true);
    }
    public void Close()
    {
        _restartGame.gameObject.SetActive(false);
    }
}
