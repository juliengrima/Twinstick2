using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    #region Champs
    [SerializeField] int _damage = 10;
    #endregion
    #region Unity LifeCycle
    // Start is called before the first frame update
  
    #endregion
    #region Methods
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
    #endregion
}
