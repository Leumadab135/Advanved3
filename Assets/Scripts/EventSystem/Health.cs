using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    //Public Attributes
    public float CurrentHealth
    {
        get
        {
            return _currentHealth;
        }
        set
        {
            _currentHealth = value;

            if (value < 0)
            {
                _currentHealth = 0;
                Die();
            }

            if (value > _maxHealth)
                _currentHealth = _maxHealth;
        }
    }
    public event Action OnGetDamage;
    public event Action OnGetHeal;
    public event Action OnDie;


    //Private Attributes
    [SerializeField] private float _currentHealth;
    [SerializeField] private float _maxHealth = 100;
    [SerializeField] private bool _die = false;

    //Unity Callbacks
    private void Start()
    {
        CurrentHealth = _maxHealth;
    }

    //Public Methods
    public void GetDamage(float damage)
    {
        if (!_die)
        {
            CurrentHealth -= damage;

            //Event Emiter 
            OnGetDamage?.Invoke();
        }
    }

    public void GetHeal(float life)
    {
        if (!_die)
        {
            CurrentHealth += life;

            //Event Emiter 
            OnGetHeal?.Invoke();
        }

    }

    //Private Methods
    private void Die()
    {
        if (!_die)
        {
            _die = true;
            //Event Emiter 
            OnDie?.Invoke();
        }
    }
}
