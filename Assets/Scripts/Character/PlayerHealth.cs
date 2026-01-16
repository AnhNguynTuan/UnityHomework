using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float defaultHealth;
    public float currentHealth;

    private void Awake()
    {
        currentHealth = defaultHealth;
    }
    public void TakeDamage(float damage)
    {
        if (currentHealth <= 0) return;
        currentHealth -= damage;
        if (currentHealth <= 0) Die();
    }
    public virtual void Die()
    {
        Destroy(gameObject);
    }
}
