using UnityEngine;

[CreateAssetMenu(fileName = "Config", menuName = "Config/Data", order = 64)]
public class Config : ScriptableObject
{

    public float LifeTime => _lifeTimePrefab;
    public float RepeatTime => _repeatTime;
    public float Sacler => _hardScaler;

    [SerializeField] private float _lifeTimePrefab;
    [SerializeField] private float _repeatTime;
    [SerializeField] private float _hardScaler;
}
