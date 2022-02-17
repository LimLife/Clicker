using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public abstract void Set(float score, float lifeTime);
    public abstract void Clicking();
    public abstract float Range { get; }
    public abstract Vector2 Point { get; }
    public abstract float Score { get; }
    public abstract TypeItems TypeItems { get; }
    public abstract Sprite Icon { get; }
    
}
