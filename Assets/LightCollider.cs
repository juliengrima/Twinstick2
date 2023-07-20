using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
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
