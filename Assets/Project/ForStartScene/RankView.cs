using UnityEngine;
using UnityEngine.UI;

public class RankView : MonoBehaviour
{

    [SerializeField] private Text _text;
    public void ViewRank()
    {
        _text.text = "Rank: "+ Instance.Singleton.GetScore().ToString();
    }
}
