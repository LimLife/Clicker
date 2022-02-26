using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CoreGame : MonoBehaviour, IEntity
{
    [SerializeField] private Spawner _spawner;
    [SerializeField] private Camera _camera; // add to config
    [SerializeField] private ViewUIGame _view;
    private RegestrationSystem _regestaration;
    [SerializeField]private GameTime _time;
    public IMediator _mediator => throw new System.NotImplementedException();

    private DataSystem _data;
    public void Initialize()
    {   
        _data = new DataSystem(_camera);
        _regestaration = new RegestrationSystem(_spawner, _data,_view,_time);

        SubscribeSystem();
    }

    public void Notify(ClickData data)
    {
        throw new System.NotImplementedException();
    }

    private void SubscribeSystem()
    {
        foreach (var item in _regestaration.EventModuls)
        {
            item.Susubscribe();
        }
    }
    private void Update()
    {
        foreach (var item in _regestaration.Moduls)
        {
            item.Execute();
        }
    }
}
