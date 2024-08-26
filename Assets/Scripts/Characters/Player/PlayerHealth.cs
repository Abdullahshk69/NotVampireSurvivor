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

    public void OnHeal(float heal)
    {
        curHeatlh = Mathf.Clamp(curHeatlh + heal, 0, maxHeatlh);
    }

    public void OnDamage(float damage)
    {
        curHeatlh -= damage;
    }

    public bool IsAlive()
    {
        return curHeatlh > 0;
    }
}
