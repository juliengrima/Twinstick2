using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    #region Champs
    [Header("Attached")]
    [SerializeField] GameObject _playerLight;
    //[SerializeField] GameObject _model;

    [Header("Fields")]
    [SerializeField] int _damage = 10;
    #endregion
    #region Unity LifeCycle
    // Start is called before the first frame update

    #endregion
    #region Methods
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Component
        //EnemyTag tag = collision.gameObject.GetComponent<EnemyTag>();
        if (collision.attachedRigidbody == null) return;

        //PlayerTag tag = collision.attachedRigidbody.gameObject.GetComponent<PlayerTag>();

        if (collision != null)
        {
            // VERIFICATION DES COLLIDERS DU RIGIDBODY DE HUMAN
            if (collision.attachedRigidbody.gameObject.CompareTag("PlayerLight"))
            {
                if (collision.enabled == false)
                {
                    collision.enabled = true;
                }
            }
            else if (collision.attachedRigidbody.gameObject.CompareTag("Player"))
            {
                if (collision.attachedRigidbody.TryGetComponent(out Health health))
                {
                    health.TakeDamage(_damage);
                    Destroy(gameObject);
                }
            } 
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.attachedRigidbody == null) return;

        if (collision != null)
        {
            if (collision.isActiveAndEnabled)
            {
                collision.enabled = false;
            }
        }
    }
    #endregion
}
