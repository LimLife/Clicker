using UnityEngine;

public struct ClickData 
{
    public Sprite Icon { get; }
    public float Score { get; }
    public TypeItems TypeItem { get; }
    public ClickData(float score,TypeItems type,Sprite icon)
    {
        Icon = icon;
        Score = score;
        TypeItem = type;
    }
}
