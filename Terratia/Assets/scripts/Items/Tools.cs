using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tools : Items
{
    [SerializeField] TypeTools _tools;
    [SerializeField] MaterialTools _material;
    [SerializeField]private int _endurance;
    private enum TypeTools
    {
        shovel,
        pickaxe,
        axe,
        hoe
    }
    private enum MaterialTools
    {
        stone,
        iron,
        gold,
        diamond
    }

    private void dig()
    {

    }
    private void Batting()
    {

    }
    private void hack()
    {

    }
    private void loosen()
    {

    }
    private void DecrementEndurance()
    {
        --_endurance;
    }
    private void ToBreak()
    {
        Destroy(gameObject, 1);
    }
}
