using System;
using UnityEngine;
using System.Collections.Generic;

public class PoolObject <T> where T:MonoBehaviour
{
    public T Prefab { get; }
    public bool Expand { get; set; }
    public Transform Container { get;}
    private List<T> _pool;
    public PoolObject(T prefab,int count)
    {
        Prefab = prefab;
        Container = null;
        Create(count);
    }
    public PoolObject(T prefab, int count,Transform container)
    {
        Prefab = prefab;
        Container = container;
        Create(count);
    }
    private void Create(int count)
    {
        _pool = new List<T>();
        for (int i = 0; i < count; i++)
        {
            CreateGameObject();
        }
    }
    private T CreateGameObject( bool isExpand = false)
    {
        var obj = UnityEngine.Object.Instantiate(Prefab, Container);
        obj.gameObject.SetActive(isExpand);
        _pool.Add(obj);
        return obj;
    }
    public T GetFreeElement()
    {
        if (HasFreeElement(out var element))
        {
            return element;
        }
        if (Expand)
        {
            return CreateGameObject(true);
        }
        throw new Exception("No elemnt");
    }
    public bool HasFreeElement(out T element)
    {
        foreach (var item in _pool)
        {
            if (!item.gameObject.activeInHierarchy)
            {
                element = item;
                item.gameObject.SetActive(true);
                return true;
            }
        }
        element = null;
        return false;
    }
    
}
