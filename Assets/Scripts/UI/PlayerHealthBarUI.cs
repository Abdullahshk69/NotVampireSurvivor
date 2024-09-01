using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBarUI : MonoBehaviour
{
    [SerializeField] PlayerHealth health;
    [SerializeField] Slider slider;

    private void Update()
    {
        slider.value = health.CurHeatlh / health.maxHeatlh;
    }
}
