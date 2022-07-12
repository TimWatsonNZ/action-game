using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentWeaponScript : MonoBehaviour
{
    [SerializeField]
    protected Weapon weapon;

    private void Awake()
    {
        weapon = GetComponentInChildren<Weapon>();
    }

    public void Shoot()
    {
        weapon?.Shoot();
    }

    public void StopShooting()
    {
        weapon?.StopShoot();
    }
}
