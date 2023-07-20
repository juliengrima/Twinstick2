using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLight : MonoBehaviour
{
    [Header("Attached")]
    [SerializeField] GameObject playerLight; // Reference to the playerlight GameObject
    [SerializeField] GameObject human; // Reference to the Human GameObject
    // Start is called before the first frame update
    void Start()
    {
        // Check if both GameObjects are assigned
        if (playerLight == null || human == null)
        {
            Debug.LogError("Please assign the playerlight and human GameObjects in the Inspector.");
            return;
        }

        // Get the Transform component of the Human GameObject
        Transform humanTransform = human.transform;

        // Attach the playerlight to the Human GameObject
        //playerLight.transform.parent = humanTransform;
        playerLight.transform.parent = humanTransform;

        // Set the local position and rotation of the playerlight relative to the Human GameObject
        playerLight.transform.localPosition = new Vector3(0f, 0f, -90f); // Adjust the position as needed
        playerLight.transform.localRotation = Quaternion.identity; // Use Quaternion.identity for no rotation
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        return;
        // Component
        //if (collision.attachedRigidbody == null) return;

        //if (collision.gameObject.GetComponent<EnemyTag>())
        //{
        //    //_trigger = tag.GetComponent<Collider2D>().enabled;
        //    //if (_trigger == false)
        //    //{
        //    //    _trigger = true;
        //    //}
        //    if (collision.isTrigger == true)
        //    {
        //        collision.isTrigger = false;
        //    }
        //}
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        return;
        //if (collision.attachedRigidbody == null) return;

        //EnemyTag tag = collision.gameObject.GetComponent<EnemyTag>();
        //if (tag != null)
        //{
        //    //_trigger = tag.GetComponent<Collider2D>().enabled;
        //    //if (_trigger == true)
        //    //{
        //    //    _trigger = false;
        //    //}
        //    if (collision.isTrigger == false)
        //    {
        //        collision.isTrigger = true;
        //    }
        //}
    }
}
