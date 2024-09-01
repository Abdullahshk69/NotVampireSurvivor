using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRecoveryUpgrade : AbstractUpgrade
{
    protected override void ApplyUpgrade()
    {
        GameManager.instance.PlayerRecovery += increaseStat;
    }
}
