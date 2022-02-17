using UnityEngine;
using UnityEngine.UI;

public class BuffUI : MonoBehaviour
{
    [SerializeField] private Image _buffBoom;
    [SerializeField] private Image _buffMultyplay;
    [SerializeField] private Image _buffDefault;

    public void BuffView(ClickData click)
    {
        switch (click.TypeItem)
        {
            case TypeItems.Boomb:

                break;

            case TypeItems.Multyplay:

                break;

            case TypeItems.Default:

                break;
                         
            default:
                break;
        }
    }
}
