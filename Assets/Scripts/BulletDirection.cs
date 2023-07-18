using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class BulletDirection : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] int _damage;
    Vector2 _direction;

    private void Reset()
    {
        _speed = 5f;
        _damage = 10;
    }

    internal void SetDirection(CursorPosition aimCursor)
    {
        _direction = (aimCursor.transform.position - transform.position).normalized;
    }

    private void Update()
    {
        transform.Translate(_direction * _speed);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Component
        EnemyTag tag = collision.gameObject.GetComponent<EnemyTag>();
        if(tag != null)
        {
            Destroy(tag.gameObject);
            Destroy(gameObject);
        }

        if(collision.TryGetComponent(out Health health))
        {
            health.TakeDamage(_damage);
            Destroy(gameObject);
        }
    }

}
