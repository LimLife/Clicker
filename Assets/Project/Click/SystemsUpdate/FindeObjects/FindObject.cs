using UnityEngine;
public class FindObject : ISystem
{
    private readonly Camera _camera;
    public Item ClikedItem { get; private set; }
    private DataSystem _data;
    public FindObject(DataSystem data)
    {
        _camera = data.Camera;
        _data = data;
    }
    public void Execute()
    {
        ClikedItem = null;
        if (_data.IsDo == true)
        {
            ClikedItem = ClickTest();
            _data.ViewHandler(this);
        }
    }

    private Item ClickTest()
    {
        var collection = _data.Items;
        for (int i = 0; i < collection.Count; i++)
        {
            if (Mathf.Abs(Distance(ClickPostion(), collection[i].Point)) <= collection[i].Range)
            {
                collection[i].Clicking();
                return collection[i];
            }
        }
        return null;
    }


    private Vector3 ClickPostion()
    {
        return _camera.ScreenToWorldPoint(Input.mousePosition);
    }
    private float Distance(Vector3 point, Vector2 centerСircle)
    {
        return ((point.x - centerСircle.x) * 2) + ((point.y - centerСircle.y) * 2);
    }

}

