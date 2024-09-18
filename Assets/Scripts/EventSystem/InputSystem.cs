using System;
using UnityEngine;

public class InputSystem : MonoBehaviour
{
    //Actions
    public event Action OnKeyDamage;
    public event Action OnKeyHeal;
    public event Action OnKeyPoints;
    public event Action OnKeyLevel;

    private void Start()
    {
        Debug.Log("Press Entern to Damage");
        Debug.Log("Press Space to Heal");
        Debug.Log("Press Escape to add Points");
        Debug.Log("Press Q to add 1 Level");
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
            OnKeyDamage?.Invoke();
        if (Input.GetKeyUp(KeyCode.Space))
            OnKeyHeal?.Invoke();
        if (Input.GetKeyUp(KeyCode.Escape))
            OnKeyPoints?.Invoke();
        if (Input.GetKeyUp(KeyCode.Q))
            OnKeyLevel?.Invoke();
    }
}
