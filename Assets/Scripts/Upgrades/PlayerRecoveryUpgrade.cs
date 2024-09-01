using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRecoveryUpgrade : AbstractUpgrade
{
    private void Start()
    {
        OnStart();
    }

    protected override void ApplyUpgrade()
    {
        GameManager.instance.PlayerRecovery += increaseStat;
    }
}
