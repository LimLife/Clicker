using UnityEngine;
public class ClickInput
{
    private Camera _cameraMain;

    public ClickInput(Camera camera)
    {
        _cameraMain = camera;
    }

    public Vector3 ClickPostion()
    {
        return _cameraMain.ScreenToWorldPoint(Input.mousePosition);
    }
}
