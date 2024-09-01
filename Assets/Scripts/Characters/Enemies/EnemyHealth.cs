using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    private float curHealth;
    [SerializeField] float score;

    IEnumerator Start()
    {
        yield return null;
        maxHealth *= GameManager.instance.EnemyDifficulty;
        curHealth = maxHealth;
        score *= GameManager.instance.EnemyDifficulty;
        GameManager.instance.playerRevive += Die;
    }

    public void TakeDamage(float damage)
    {
        curHealth -= damage;
        if(curHealth <= 0 )
        {
            Die();
        }
    }

    public void Die()
    {
        StartCoroutine(DieNextFrame());
    }

    IEnumerator DieNextFrame()
    {
        yield return null;
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        GameManager.instance.playerRevive -= Die;
        GameManager.instance.AddScore((int)score);
    }
}
