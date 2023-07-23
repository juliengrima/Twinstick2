using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    #region Champs
    [SerializeField] string _level = "";
    #endregion
    #region Unity LifeCycle
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.attachedRigidbody.gameObject.CompareTag("Player"))
        {








            SceneManager.LoadScene(_level);
        } 
    }
    #endregion
    #region Methods
   
    #endregion
}
