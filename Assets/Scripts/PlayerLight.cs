using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLight : MonoBehaviour
{
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        // Component
        if (collision.attachedRigidbody == null) return;

        if (collision.attachedRigidbody.gameObject.GetComponent<EnemyTag>())
        { 
            if (collision.enabled == false)
            {
                collision.enabled = true;
            }
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.attachedRigidbody == null) return;

        EnemyTag tag = collision.attachedRigidbody.gameObject.GetComponent<EnemyTag>();
        if (tag != null)
        {
            if (collision.isActiveAndEnabled)
            {
                collision.enabled = false;
            }
        }
    }
}
