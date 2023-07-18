using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    #region Champs
    [SerializeField] string _level = "";
    #endregion
    #region Unity LifeCycle
    // Start is called before the first frame update
    public void LoadGame()
    {
        SceneManager.LoadScene(_level);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
    #region Methods
    void FixedUpdate (){
        
    }
    void LateUpdate (){
        
    }
    #endregion
}
