using UnityEngine;
public class  Instance : MonoBehaviour
{
    private DataController _controller;
    public static Instance Singleton
    {
        get
        {
            if (_singleton == null)
            {
                var go = new GameObject("Data");
                _singleton = go.AddComponent<Instance>();
                DontDestroyOnLoad(go);
                _singleton.Init();
            }
            
            return _singleton;
        }
    }
    private static Instance _singleton;

    
    private void Init()
    {
        _controller = new DataController();
    }
    public void AddScore(int score)
    {
        _controller.AddScore(score);
    }
    public int GetScore()
    {
      return  _controller.Score;
    }
    public void Save()
    {
        _controller.Save();
    }
}
