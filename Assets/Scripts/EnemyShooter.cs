using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    #region Champs
    [SerializeField] int _damage = 10;
    bool _trigger = false;
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

        PlayerTag tag= collision.attachedRigidbody.gameObject.GetComponent<PlayerTag>();
        if (tag != null)
        {
            //switch (tag)
            //{
            //    case :
            //        break;
            //    case :
            //        break;
            //    case :
            //        break;
            //    case :
            //        break;
            //    default:
            //        break;
            //}


            if (collision.attachedRigidbody.TryGetComponent(out LightCollider lightCollider))
            {
                return;
            }
            else if (collision.attachedRigidbody.TryGetComponent(out Health health))
            { 
                health.TakeDamage(_damage);
                Destroy(gameObject);
            }
        }
    }
    #endregion
}
