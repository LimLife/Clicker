public class Scoring : IEventSystem
{
    public float Score { get; private set; }
    private DataSystem _data;

    public Scoring(DataSystem data)
    {
        _data = data;
    }

    public void Susubscribe()
    {
        _data.ItemEvent += AddingScore;
    }

    private void AddingScore(Item item)
    {
        if (item == null)
        {
            return;
        }
        Score += item.Score;
        _data.BuffSystemData(this);
    }

    public void UnSubscribe()
    {
        _data.ItemEvent -= AddingScore;
    }
}
