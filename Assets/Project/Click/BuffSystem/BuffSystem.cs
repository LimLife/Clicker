using System;
public class BuffSystem
{
    public float Score { get; private set; }

    public ClickData BuffSocre(Item data)
    {
        if (data == null)
        {
            return new ClickData();
        }
        switch (data.TypeItems)
        {
            case TypeItems.Boomb:
                Score -= data.Score;
                return (new ClickData(Score, data.TypeItems, data.Icon));
            case TypeItems.Multyplay:
                Score *= 1.5f;
                return (new ClickData(Score, data.TypeItems, data.Icon));

            case TypeItems.Default:
                Score += data.Score;
                return (new ClickData(Score, data.TypeItems, data.Icon));

            default:
                throw new Exception("Not that type");
        }
    }
}
