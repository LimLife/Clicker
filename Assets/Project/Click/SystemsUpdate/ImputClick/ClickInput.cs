using UnityEngine;
public class ClickInput : ISystem
{
    public Vector3 ClickPostion { get; private set; }

    private bool _isClick;

    private readonly Camera _cameraMain;
    private readonly DataSystem _data;
    public ClickInput(DataSystem data)
    {
        _data = data;
        _cameraMain = _data.Camera;
    }
    public void Execute()
    {
        _isClick = false;
        if (Input.GetMouseButtonDown(0))
        {
            _isClick = true;
            Click();
        }
        _data.IsActive(_isClick);
    }

    private void Click()
    {
        _cameraMain.ScreenToWorldPoint(Input.mousePosition);
        _data.ClickInput(this);
        _data.IsActive(_isClick);
    }

}
