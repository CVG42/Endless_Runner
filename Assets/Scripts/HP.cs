using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public float StartingHP;
    public float currentHP { get; private set; }

    private void Awake()
    {
        currentHP = StartingHP;
    }

    public void Damage(float _dmg)
    {
        currentHP = Mathf.Clamp(currentHP - _dmg, 0, StartingHP);
        if (currentHP > 0)
        {

        }
        else
        {

        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Damage(1);
        }
    }

    public void extraHP(float _value)
    {
        currentHP = Mathf.Clamp(currentHP + _value, 0, StartingHP);
    }
}
