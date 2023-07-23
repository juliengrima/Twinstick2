using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    #region Champs
    [Header("Health")]
    [SerializeField] int _startHealth;
    [SerializeField] int _startHealthMax;

    [Header("Scores")]
    [SerializeField] int _scoreOnDeath;
    [SerializeField] int _scoreOnLife;
    [SerializeField] bool _isPlayer = false;

    [Header("Effects")]
    [SerializeField] float disableDuration = 1f;
    [SerializeField] UnityEvent _effect;
    
    #endregion
    #region Coroutines

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
        if (_isPlayer == true)
        {
            ScoreManager.Instance.DeleteScore(_scoreOnDeath);
        }
        if (_startHealth <= 0)
        {
            if (_isPlayer == true)
            {
                ScoreManager.Instance.DeleteScore(_scoreOnDeath * 2);
                SceneManager.LoadScene("Menu");
            }
            else
            {
                ScoreManager.Instance.AddScore(_scoreOnDeath);
            }

            StartCoroutine(EnableDestroyAfterDelay());
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
                ScoreManager.Instance.AddScore(_scoreOnLife);
            }
        }

        #endregion
    }

    public IEnumerator EnableDestroyAfterDelay()
    {
        Collider2D collider = gameObject.GetComponent<Collider2D>();
        collider.enabled = false;
        _effect.Invoke();
        yield return new WaitForSeconds(disableDuration);
        Destroy(gameObject);
    }
}