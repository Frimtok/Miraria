using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firearms : Weapon
{
    [SerializeField]private Bullet _bullet;
    [SerializeField] private GameObject _target; 
    private enum TypeEra
    {
        middleAges,
        newtime,
        modern
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _bullet.Spawn(_target.transform.position);
        }
    }
}
