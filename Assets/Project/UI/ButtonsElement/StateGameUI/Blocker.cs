using UnityEngine;

public class Blocker : MonoBehaviour
{
    [SerializeField] private GameObject _blocker;
    private void Start()
    {
        _blocker.transform.position = new Vector3(0, 0, -4f);
        _blocker.transform.localScale = new Vector3(15, 30, 0); //Setting random ,future config or script reference setting  
    }


    public void Show()
    {
        _blocker.gameObject.SetActive(true);
    }
    public void Close()
    {
        _blocker.gameObject.SetActive(false);

    }
}
