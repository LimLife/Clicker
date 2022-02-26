using System.Collections.Generic;
using UnityEngine;
using System;

public class DataSystem
{
    public event Action<float> ScoreEvent;
    public event Action<Item> ItemEvent;
    public bool IsDo { get; private set; } = false;
    public bool TimeUpGame { get; private set; } = false;
    public Vector3 PostionClick { get; private set; }
    public List<Item> Items => _pool._pool;
    public Camera Camera { get; private set; }
    public float Score { get; private set; }

    private Pool<Item> _pool;
    public DataSystem(Camera camera)
    {
        Camera = camera;
    }
    public void BuffSystemData(Scoring buff)
    {
        Score = buff.Score;
        ScoreEvent?.Invoke(Score);
    }
    public void SpawnerData(Pool<Item> pool)
    {
        _pool = pool;
    }
    public void TimeUp(GameTimeUI time)
    {
        TimeUpGame = time.TimeUp;
    }
    public void ViewHandler(FindObject view)
    {
        ItemEvent?.Invoke(view.ClikedItem);
    }
    public void ClickInput(ClickInput click)
    {
        PostionClick = click.ClickPostion;
    }
    public void IsActive(bool isClick)
    {
        IsDo = isClick;       
    }
}


