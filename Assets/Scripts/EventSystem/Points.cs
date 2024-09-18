using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public int CurrentPoints { get; set; }
    public int CurrentLevel { get; set; }

    public event Action OnGetPoints;
    public event Action OnLevelUpByPoints;
    public event Action OnLevelUpByKey;

    void Start()
    {
        CurrentPoints = 0;
        CurrentLevel = 1;
    }

    public void AddPoints(int pointsToAdd)
    {
        CurrentPoints += pointsToAdd;
        OnGetPoints?.Invoke();

        AddLevelByPoints();
    }

    private void AddLevelByPoints()
    {
        if (CurrentPoints >= CurrentLevel * 200)
        {
            CurrentLevel+= 1;
            OnLevelUpByPoints?.Invoke();
        }
    }
    public void AddLevelByKey()
    {
        CurrentLevel += 1;
        OnLevelUpByKey?.Invoke();
    }
}
