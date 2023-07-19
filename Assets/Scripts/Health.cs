using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    #region Champs
    [SerializeField] int _startHealth;
    [SerializeField] int _scoreOnDeath;
    [SerializeField] bool _isPlayer = false;
    #endregion
    #region Unity LifeCycle
    // Start is called before the first frame update
    private void Reset()
    {
        _startHealth = 100;
        _scoreOnDeath = 100;
    } 
    #endregion
    #region Methods

    public void TakeDamage(int amount)
    {
        _startHealth -= amount;

        if (_startHealth <= 0)
        {
            if (_isPlayer == true)
            {
                ScoreManager.Instance.DeleteScore(_scoreOnDeath * 2);
            }
            else
            {
                ScoreManager.Instance.AddScore(_scoreOnDeath);
            }

            Destroy(gameObject);
        }
    }
    #endregion
}
