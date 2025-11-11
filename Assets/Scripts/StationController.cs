using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StationController : MonoBehaviour
{
    public int health;
    public Text healthBar;
    public PauseActivator pauseActivator;

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
    private void Update()
    {
        healthBar.text = health.ToString("HP: ") + health;

        if (health <= 0)
        {
            pauseActivator.GameOver();
        }
    }
    public void HealthUp()
    {
        health += 3;
    }
}
