using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Block : Items
{
    [SerializeField]private bool _IsBackGraynd;
    [SerializeField]private bool _IsPhysical;
    private Rigidbody2D _rigidbody2D;
    private BoxCollider2D _boxCollider2D;
    private void Create()
    {

    }
    private void ToPutBack()
    {

    }
    private void ToPut()
    {

    }
    private void DisablePhysical()
    {
        _rigidbody2D.bodyType = RigidbodyType2D.Static;
    }
    private 
    protected void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _boxCollider2D = GetComponent<BoxCollider2D>();
        if (_IsPhysical == false)
        {
            DisablePhysical();
        }
    }
}
