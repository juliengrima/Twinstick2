using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AutoDestroy : MonoBehaviour
{

    float _startLife;
    [SerializeField] UnityEvent _effect;

    private void Start()
    {
        _startLife = Time.time;
    }

    private void Update()
    {
        
        if( Time.time > _startLife + 2 )
        {
            _effect.Invoke();
            //Destroy( gameObject );
        }
    }

}
