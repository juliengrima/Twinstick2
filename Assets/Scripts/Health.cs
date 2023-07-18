using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    #region Champs
    [SerializeField] int _startHealth;
    [SerializeField] bool _isPlayer;
    [SerializeField] int _scoreOnDeath;
    #endregion
    #region Unity LifeCycle
    // Start is called before the first frame update
    private void Reset(BulletDirection damage)
    {
        _startHealth = 100;
        _scoreOnDeath = 10;
    }
    //void Awake()
    //{
        
    //}
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    //void Update()
    //{
        
    //}
    #endregion
    #region Methods
    //void FixedUpdate (){
        
    //}
    //void LateUpdate (){
        
    //}

    public void TakeDamage(int amount)
    {
        _startHealth -= amount;

        if (_startHealth <= 0)
        {
            if (_isPlayer)
            {
                ScoreManager.Instance.DeleteScore(_scoreOnDeath);
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
