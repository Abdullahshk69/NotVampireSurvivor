using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [field:SerializeField] public float maxHeatlh {  get; private set; }
    public float CurHeatlh { get; private set; }
    [SerializeField] private float healthRegen;

    IEnumerator Start()
    {
        yield return null;
        maxHeatlh += GameManager.instance.PlayerHealth;
        CurHeatlh = maxHeatlh;
        healthRegen += GameManager.instance.PlayerRecovery;
        GameManager.instance.playerRevive += PlayerRevived;
    }

    private void Update()
    {
        CurHeatlh = Mathf.Clamp(CurHeatlh + (healthRegen * Time.deltaTime), 0, maxHeatlh);
    }

    private void PlayerRevived()
    {
        CurHeatlh = maxHeatlh;
    }

    public void TakeHeal(float heal)
    {
        CurHeatlh = Mathf.Clamp(CurHeatlh + heal, 0, maxHeatlh);
    }

    public void TakeDamage(float damage)
    {
        CurHeatlh -= damage;
        if(CurHeatlh<=0)
        {
            // Lose game
            GameManager.instance.GameOver();
        }
    }

    public bool IsAlive()
    {
        return CurHeatlh > 0;
    }
}
