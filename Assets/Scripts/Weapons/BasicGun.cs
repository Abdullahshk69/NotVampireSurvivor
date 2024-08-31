using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicGun : BaseWeapon
{
    private float timer;
    [SerializeField] private GameObject projectile;
    [SerializeField] private float damage;

    private void Start()
    {
        timer = 0.0f;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= weaponSpeed)
        {
            StartCoroutine(Shoot());

            timer = 0.0f;
        }
    }

    IEnumerator Shoot()
    {
        for (int i = 0; i < projectileCount; i++)
        {
            GameObject projectiles = Instantiate(projectile, transform.position, Quaternion.identity);
            projectiles.GetComponent<BasicGunProjectile>().SetVariables(GameManager.instance.LookDirection, damage);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
