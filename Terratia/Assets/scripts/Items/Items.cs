using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract  class Items : MonoBehaviour
{
    [SerializeField] private string _name;

    public string GetName()
    {
        return _name;
    }  
    protected void Drop()
    {
        
    }
    protected void DestroyWhenLifting()
    {

    }
}
