using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColdWeapons: Weapon
{
    [SerializeField] private CircleCollider2D _damageRadius;
    [SerializeField] private int _damage;
}
