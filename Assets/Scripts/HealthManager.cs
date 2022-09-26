using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public HP playerHP;
    public Image totalHP;
    public Image currentHP;

    private void Start()
    {
        totalHP.fillAmount = playerHP.currentHP / 10;
    }

    private void Update()
    {
        currentHP.fillAmount = playerHP.currentHP / 10;
    }
}
