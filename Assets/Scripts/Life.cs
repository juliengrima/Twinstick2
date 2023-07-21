using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Life : MonoBehaviour
{
    [SerializeField] int _life = 40;
    [SerializeField] UnityEvent _onPicked;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Component
        if (collision.attachedRigidbody == null) return;
        //PlayerTag tag = collision.attachedRigidbody.gameObject.GetComponent<PlayerTag>();
        if (collision.gameObject.CompareTag("Player"))
        {  
            var life = collision.gameObject.GetComponent<Health>();
            life.GiveLife(_life);
            _onPicked.Invoke();
            //desactive le gameObject au lieu de le supprimer
            //gameObject.SetActive(false);  
        }
    }
}
