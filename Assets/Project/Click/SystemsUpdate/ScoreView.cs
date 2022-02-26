public class ScoreView : IEventSystem
{
    private DataSystem _data;
    private ViewUIGame _view;
    public ScoreView(DataSystem data,ViewUIGame view)
    {
        _data = data;
        _view = view;
    }
   
    public void Susubscribe()
    {
        _data.ScoreEvent += Score;
    }
    public void UnSubscribe()
    {
        _data.ScoreEvent -= Score;
    }

    private void Score(float score)
    {
        _view.SetScore(score);
    }
}
    

