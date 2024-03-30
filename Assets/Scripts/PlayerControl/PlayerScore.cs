using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using TMPro;

public class PlayerScore : MonoBehaviour
{
    private void Start()
    {
        DrawUI();
    }
    public RectTransform experienceValueRectTransform;
    public TextMeshProUGUI levelValueTMP;

    private int _levelValue = 1;

    private float _experienceCurrectValue = 0;
    private float _experienceTargetValue = 100;

    public void AddExperience(float value)
    {
        _experienceCurrectValue += value;
        if(_experienceCurrectValue >= _experienceTargetValue)
        {
            _levelValue += 1;
            _experienceCurrectValue = 0;
        }
        DrawUI();
    }

    private void DrawUI()
    {
        experienceValueRectTransform.anchorMax = new Vector2(_experienceCurrectValue / _experienceTargetValue, 1);
        levelValueTMP.text = _levelValue.ToString();
    }
}
