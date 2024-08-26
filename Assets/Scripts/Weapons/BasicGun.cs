using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicGun : BaseWeapon
{
    private float timer;
    [SerializeField] private GameObject projectile;

    private void Start()
    {
        projectileCount = 1;
        weaponDamage = 10;
        weaponSpeed = 2f;

        timer = 0.0f;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= weaponSpeed)
        {
            GameObject projectiles = Instantiate(projectile, transform.position, Quaternion.identity);
            projectile.GetComponent<BasicGunProjectile>().SetDirection(GameManager.instance.LookDirection);
            timer = 0.0f;
        }
    }
}
