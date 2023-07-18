using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardPlayer : MonoBehaviour
{

    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float _speed;
    [SerializeField] int _damage = 10;

    private void Update()
    {
        if (PlayerController.Instance == null) return;

        var dir = (PlayerController.Instance.transform.position - transform.position).normalized;

        _rb.MovePosition(transform.position + (dir * _speed));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Component
        PlayerTag tag = collision.gameObject.GetComponent<PlayerTag>();
        if (tag != null)
        {
            if (collision.TryGetComponent(out Health health))
            {
                health.TakeDamage(_damage);
                Destroy(gameObject);
            }
        }
    }

}
