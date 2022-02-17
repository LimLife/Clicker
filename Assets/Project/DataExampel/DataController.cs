public class DataController
{
    private readonly DataBase _data;
    public int Score => _data.Score;
    public DataController()
    {
        _data = new DataBase();
    }
    public void Save()
    {
        _data.SaveData();
    }
    public int Load()
    {
      return  _data.LoadData();
    }
    public void AddScore(int score)
    {
        _data.Score += score;
    }
}


