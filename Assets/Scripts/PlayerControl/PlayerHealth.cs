using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float value = 100;
    public RectTransform valueRectTransform;
    private float _maxValue;
    public GameObject gameplayUI;
    public GameObject gameOverScreen;
    public Animator animator;
    private void Start()
    {
        _maxValue = value;
        DrawHealthBar();
        gameOverScreen.SetActive(false);
        gameplayUI.SetActive(true);
        animator.SetBool("Alive", true);
    }
    public void DealDamage(float damage)
    {
        value -= damage;
        if (value <= 0)
        {
            PlayerIsDead();
        }
        DrawHealthBar();
    }
    private void DrawHealthBar()
    {
        valueRectTransform.anchorMax = new Vector2(value / _maxValue, 1);
    }
    private void PlayerIsDead()
    {
        gameOverScreen.SetActive(true);
        gameplayUI.SetActive(false);
        animator.SetBool("Alive", false);
        GetComponent<PlayerController>().enabled = false;
        GetComponent<CreateFireballConroller>().enabled = false;
        GetComponent<PlayerController>().enabled = false;
        GetComponent<CameraController>().enabled = false;
    }
    public void AddHealth(float amount)
    {
        value += amount;
        value = Mathf.Clamp(value, 0, _maxValue);
        DrawHealthBar();
    }
}
