using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AutoDestroy : MonoBehaviour
{
    float _startLife;
    [SerializeField] UnityEvent _effect;
    [SerializeField] UnityEvent _onStart;
    Collider2D _collision;

    private void Start()
    {
        _startLife = Time.time;
        _onStart.Invoke();  
    }

    private void Update()
    {
        _effect.Invoke();

        //if (_collision.CompareTag("Wall"))
        //{
        //    Destroy(gameObject);
        //}
        if ( Time.time > _startLife + 2 )
        {
            Destroy( gameObject );
        }
    }
}
