using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    #region Champs
    [Header("Health")]
    [SerializeField] int _startHealth;
    [SerializeField] int _startHealthMax;

    [Header("Others")]
    [SerializeField] int _scoreOnDeath;
    [SerializeField] bool _isPlayer = false;
    #endregion
    #region Unity LifeCycle
    // Start is called before the first frame update
    private void Awake()
    {
        _startHealth = _startHealthMax;
       
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

    public void GiveLife(int amount)
    {
        if (_startHealth > 0 && _startHealth < _startHealthMax)
        {
            _startHealth += amount;
            if (_startHealth > _startHealthMax)
            {
                _startHealth = _startHealthMax;
                ScoreManager.Instance.AddScore(_scoreOnDeath);
            }
        }

        #endregion
    }
}