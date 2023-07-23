using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Collider2D _collision;
    [SerializeField] float disableDuration = 1f; // Durée pendant laquelle le Collider de l'Enemy est désactivé
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HitByLight()
    {
        // Implémentez ici le comportement du fantôme lorsque touché par la lumière
        Debug.Log("Fantôme touché !");
        // Réduisez les points de vie du fantôme, jouez une animation, etc.
        if (!_collision.enabled && _collision.CompareTag("PlayerLight"))
        {
            _collision = gameObject.GetComponent<CircleCollider2D>();
            _collision.enabled = true;
        }
        //StartCoroutine(EnableColliderAfterDelay(_collision));
    }

    private IEnumerator EnableColliderAfterDelay(Collider2D enemyCollider)
    {
        yield return new WaitForSeconds(disableDuration);

        // Réactiver le Collider de l'Enemy
        enemyCollider.enabled = false;
    }
}
