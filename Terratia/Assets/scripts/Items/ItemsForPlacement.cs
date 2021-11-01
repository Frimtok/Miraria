using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemsForPlacement : Items
{
    [SerializeField] items _item;
    private enum items
    {
        fire,
        bake,
        workbench
    }
}
