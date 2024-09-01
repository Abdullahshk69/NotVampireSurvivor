using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileAmountUpgrade : AbstractUpgrade
{
    private void Start()
    {
        OnStart();
    }

    protected override void ApplyUpgrade()
    {
        GameManager.instance.ProjectileAmount += (int)increaseStat;
    }
}
