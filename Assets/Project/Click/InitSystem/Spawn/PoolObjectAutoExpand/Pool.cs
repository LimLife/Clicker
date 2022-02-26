using System;
using UnityEngine;
using System.Collections.Generic;

public class Pool <T> where T :MonoBehaviour
{  
    public T Prefab { get; }
    public bool Expand { get; set; }
    public Transform Container { get; }
    public List<T> _pool { get; private set; }

    
    private readonly T [] _poolDifferent;
    
   
    public Pool(Transform container,int count,T []  prefabs)
    {
        _poolDifferent = prefabs;
        _pool = new List<T>();
        Container = container;
        Create(count);
    }
    public Pool( int count, T [] prefabs)
    {
        _poolDifferent = prefabs;
        _pool = new List<T>();
        Container = null;
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
    private T CreateGameObject(bool isExpand = false)
    {
        var obj = UnityEngine.Object.Instantiate(_poolDifferent[UnityEngine.Random.Range(0,_poolDifferent.Length)] ,Container);
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
