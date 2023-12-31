using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    #region Champs
    [SerializeField] string _level = "";
    [SerializeField] GameObject _enemy;
    int _score;

    #endregion
    #region Unity LifeCycle
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.attachedRigidbody.gameObject.CompareTag("Player"))
        {
            var boss = GameObject.FindGameObjectsWithTag("Boss").Length;
            if (boss > 0)
            {
                Debug.Log($"!!IL RESTE {boss} FANTOMES !!");
            }
            else
            {
                SceneManager.LoadScene(_level);
            }           
        } 
    }
    #endregion
    #region Methods
   
    #endregion
}
