using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIController : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _pointsText;
    [SerializeField] private TextMeshProUGUI _levelText;

    public void UpdateSliderLife (float currentLife)
    {
        _slider.value = currentLife;
    }

    public void UpdatePoints(int currentPoints)
    {
        _pointsText.text = ("Points: " + currentPoints.ToString());
    }

    public void SetLevel(int currentLevel)
    {
        _levelText.text = ("Level: " + currentLevel.ToString());
    }
}
