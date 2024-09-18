using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    [SerializeField] private Points _points;
    [SerializeField] private Health _playerHealth;
    [SerializeField] private UIController _ui;
    [SerializeField] private SoundController _sound;
    [SerializeField] private InputSystem _inputSystem;

    // Start is called before the first frame update
    void Start()
    {
        //Event Listener

        //Health
        _playerHealth.OnGetDamage += OnGetDamage;
        _playerHealth.OnGetHeal += OnGetHeal;
        _playerHealth.OnDie += OnDie;

        //Points & Level
        _points.OnGetPoints += OnAddPoints;
        _points.OnLevelUpByPoints += OnAddLevel;
        _points.OnLevelUpByKey += OnAddLevel;

        //Inputs
        _inputSystem.OnKeyDamage += OnKeyDamage;
        _inputSystem.OnKeyHeal += OnKeyHeal;
        _inputSystem.OnKeyPoints += OnKeyPoints;
        _inputSystem.OnKeyLevel += OnKeyLevel;
    }



    private void OnKeyDamage()
    {
        _playerHealth.GetDamage(25);
    }

    private void OnKeyHeal()
    {
        _playerHealth.GetHeal(25);
    }

    private void OnKeyPoints()
    {
        _points.AddPoints(50);
    }
    private void OnKeyLevel()
    {
        _points.AddLevelByKey();
    }

    private void OnGetDamage()
    {
        _sound.PlayDamageSound();
        _ui.UpdateSliderLife(_playerHealth.CurrentHealth);
    }

    private void OnGetHeal()
    {
        _sound.PlayHealSound();
        _ui.UpdateSliderLife(_playerHealth.CurrentHealth);
    }

    private void OnDie()
    {
        _sound.PlayDieSound();
        Destroy(_playerHealth.gameObject);
    }

    private void OnAddPoints()
    {
        _sound.PlayPointsSound();
        _ui.UpdatePoints(_points.CurrentPoints);
    }

    private void OnAddLevel()
    {
        _sound.PlayLevelUpSound();
        _ui.SetLevel(_points.CurrentLevel);
    }
}
