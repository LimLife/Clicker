using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameScane : MonoBehaviour
{
    public void Load()
    {
        SceneManager.LoadScene(StringTag.GameScene);
    }
}
