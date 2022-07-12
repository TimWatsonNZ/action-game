using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Weapons/WeaponData")]
public class WeaponDataSO : ScriptableObject
{
    public bool AutomaticFire { get; internal set; }
    public float WeaponDelay { get; internal set; }

    public int GetBulletCountToSpawn()
    {
        return 4;
    }
}
