using UnityEngine;
public class Click : Item
{
   
    [SerializeField] private TypeItems _items;
    [SerializeField] private SpriteRenderer _icon;
    public override TypeItems TypeItems => _items;
    public override Sprite Icon => _icon.sprite;

    public override float Range => transform.localScale.x;
    public override Vector2 Point => transform.position;

    public override float Score => _score;
    private float _score;


    public override void Clicking()
    {
        gameObject.SetActive(false);      
    }

    public override void Set(float score, float lifeTime)
    {
        _score = score;
    }
   
}
