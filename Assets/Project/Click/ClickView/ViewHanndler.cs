using UnityEngine;
using System.Collections.Generic;
public class ViewHanndler
{
    private readonly Camera _camera;

    public ViewHanndler(Camera camera)
    {
        _camera = camera;       
    }

    public Item ClickTest(List<Item> items) 
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (Mathf.Abs(Distance(ClickPostion(), items[i].Point)) <= items[i].Range)
            {
                items[i].Clicking();
               return items[i];             
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

