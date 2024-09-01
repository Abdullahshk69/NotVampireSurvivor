using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthUpgrade : AbstractUpgrade
{
    private void Start()
    {
        OnStart();
    }

    protected override void ApplyUpgrade()
    {
        GameManager.instance.PlayerHealth += increaseStat;
    }
}
