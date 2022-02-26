using UnityEngine;
[CreateAssetMenu(fileName = "Config", menuName = "Config/Time/GameTime", order = 64)]
public class GameTime : ScriptableObject
{
    public float LifeTimeGame => _lifeTimeGame;
    [SerializeField] private float _lifeTimeGame;

}
