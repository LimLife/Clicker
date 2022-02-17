using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Spawner : MonoBehaviour
{  
    [SerializeField] private Config _config;
    [SerializeField] private PrefabDate _prefab;

    private Item[] _click => _prefab.Prefab;
    private Pool<Item> _pooling;
    private Camera _camera;

    private bool _autoExpand = true;
    private Vector2 _cameraPosition;
    private int _countPrefabs;
    private float _timeRepiting;
    private bool _isSpawning;
    private float _halfTime => _timeRepiting / 2;
    private float _hardScale => _config.Sacler;
    private float _randomX
    {
        get
        {
            return (float)Random.Range(-_cameraPosition.x * 0.9f, _cameraPosition.x * 0.9f);//offset 10%
        }
    }
    private float _randomY
    {
        get
        {
            return (float)Random.Range(-_cameraPosition.y * 0.9f, _cameraPosition.y * 0.9f);//offset 10%
        }
    }


    public List<Item> Items => _pooling._pool;
   
    public void Init( Camera camera)
    {        
        _camera = camera;
        _cameraPosition = _camera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));
        _timeRepiting = _config.RepeatTime;

        _pooling = new Pool<Item>(_countPrefabs, _click)
        {
            Expand = _autoExpand
        };
        StartCoroutine(SpawnPrefab());       
    }

   
    public void Pause(bool spawning)
    {
        _isSpawning = spawning;
       
    }
    private IEnumerator SpawnPrefab()
    {
        while (true)
        {
            yield return new WaitForSeconds(_timeRepiting);          
            if (!_isSpawning)
            {             
                CrateItem();
                if (_timeRepiting > _halfTime)
                {
                    _timeRepiting -= _hardScale;
                }
            }   
            else
            {
                yield return null;
            }
        }       
    }
    private void CrateItem()
    {
        var pool = _pooling.GetFreeElement();
        var pos = new Vector3(_randomX, _randomY, 0);
        pool.transform.position = pos;
        pool.Set(10, 4f);   //Random Setting      
    }
}




