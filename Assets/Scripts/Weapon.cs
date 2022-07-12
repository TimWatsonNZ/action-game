using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    protected GameObject muzzle;

    [SerializeField]
    protected WeaponDataSO weaponData;



    [field: SerializeField]
    public UnityEvent OnShoot { get; set; }

    [field: SerializeField]
    public UnityEvent OnShootNoMana { get; set; }

    protected bool isShooting = false;

    [SerializeField]
    protected bool reloadCoroutine = false;

    public void TryShoot()
    {
        isShooting = true;
    }
    
    public void StopShoot()
    {
        isShooting = false;
    }

    private void Update()
    {
        UseWeapon();
    }

    private void UseWeapon()
    {
        if (isShooting && !reloadCoroutine)
        {
            OnShoot?.Invoke();
            for (int i = 0; i < weaponData.GetBulletCountToSpawn(); i++)
            {
                ShootBullet();
            }
        }
        FinishShooting();
    }

    private void FinishShooting()
    {
        StartCoroutine(DelayNextShotCoroutine());
        if (!weaponData.AutomaticFire)
        {
            isShooting = false;
        }
    }

    protected IEnumerator DelayNextShotCoroutine()
    {
        reloadCoroutine = true;
        yield return new WaitForSeconds(weaponData.WeaponDelay);
        reloadCoroutine = false;
    }

    private void ShootBullet()
    {
        Debug.Log("Shooting bullets.");
    }
}
