using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHeatlh;
    private float curHeatlh;

    private void Awake()
    {
        curHeatlh = maxHeatlh;
    }

    public void TakeHeal(float heal)
    {
        curHeatlh = Mathf.Clamp(curHeatlh + heal, 0, maxHeatlh);
    }

    public void TakeDamage(float damage)
    {
        curHeatlh -= damage;
        if(curHeatlh<=0)
        {
            // Lose game
        }
    }

    public bool IsAlive()
    {
        return curHeatlh > 0;
    }
}
