using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float value = 100;

    public PlayerScore playerScore;

    public Explosion explosionPrefab;

    private void Start()
    {
        playerScore = FindObjectOfType<PlayerScore>();
    }

    public void DealDamage(float damage)
    {
        playerScore.AddExperience(damage);

        value -= damage;
    }

    private void Update()
    {
        if (value <= 0)
        {
            Destroy(gameObject);
        }
    }
}
