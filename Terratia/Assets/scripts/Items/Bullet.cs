using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _damage;
    private Vector2 _side;
    private void Update()
    {
        Move(_side,_speed);
    }
    private void Move(Vector2 side, float speed)
    {
        transform.Translate(side * speed * Time.deltaTime);
    }
    private void SetRight()
    {
        _side = Vector2.right;
    }
    private void SetLeft()
    {
        _side = Vector2.left;
    }
    private void Start()
    {
        SetRight();
    }
    public void Spawn(Vector3 targetSpawn)
    {
        Instantiate(gameObject, targetSpawn, transform.rotation);
    }
}

