public struct Data
{
    public float LifeTimePrefab { get; }
    public float RepeatSpawn { get; }
    public float HardScale { get; }
    public Data(float lifeTime, float repeat, float scale)
    {
        LifeTimePrefab = lifeTime;
        RepeatSpawn = repeat;
        HardScale = scale;
    }
}