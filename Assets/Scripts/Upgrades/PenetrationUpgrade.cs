using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenetrationUpgrade : AbstractUpgrade
{
    protected override void ApplyUpgrade()
    {
        GameManager.instance.PlayerPenetration += (int)increaseStat;
    }
}
