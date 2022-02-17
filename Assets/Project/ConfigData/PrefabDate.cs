
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Config", menuName = "Config/DatePrefab", order = 64)]
public class PrefabDate : ScriptableObject
{
    public Item [] Prefab => _prefab;
    [SerializeField] private Item []  _prefab;
}
