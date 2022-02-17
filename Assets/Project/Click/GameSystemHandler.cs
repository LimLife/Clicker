using UnityEngine;
using System.Collections.Generic;
[RequireComponent(typeof(Camera))]
public class GameSystemHandler : MonoBehaviour,IEntity
{
    [SerializeField] private Camera _camera;

    [SerializeField] private Spawner _spawner;

    public float Score => _buffSystem.Score; 

    private ViewHanndler _viewHandler;
    private BuffSystem _buffSystem;

    private List<Item> _items => _spawner.Items;

    public IMediator _mediator { get; private set; }

    private bool isPause;

    public void Init(IMediator mediator)
    {
        _mediator = mediator;
        _camera = Camera.main;
        _spawner.Init(_camera);
        _viewHandler = new ViewHanndler(_camera);
        _buffSystem = new BuffSystem();        
    }
      
    private ClickData GetData()
    {
        return _buffSystem.BuffSocre(AddItem());
    }
    public void Pause(bool isGame)
    {
        isPause = isGame;
        _spawner.Pause(isPause);
    }
    private Item AddItem()
    {
        return _viewHandler.ClickTest(_items);
    }
     
    private void Update() //IEnumerator timeDeltaTime
    {
        if (Input.GetMouseButtonDown(0) && !isPause)
        {
            _mediator.Send(this, GetData());
        }
    }
  
    public void Notify(ClickData data)//???????????
    {
       
    }
}
