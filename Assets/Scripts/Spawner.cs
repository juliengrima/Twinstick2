using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float _spawnRate = 1f;
    [SerializeField] GameObject _enemy;
    [SerializeField] Transform _enemyRoot;
    [SerializeField] int enemyCount = 1;
    [SerializeField] List<GameObject> _enemies;
    [SerializeField] UnityEvent _onSpawIsFinished;


    float _lastSpawnDate;       // 20
    float _randomDelay;

    private void Update()
    {
        bool isFinished = true;

        foreach (var item in _enemies)
        {
            if (item != null)
            {
                isFinished = false;
            }

        }

        if (Time.time > _lastSpawnDate + _spawnRate + _randomDelay && enemyCount > 0)        // LSD = 25     Rate = 5            Time.time => 30
        {
            _lastSpawnDate = Time.time;
            Vector3 offset = new Vector3(Random.Range(-10, 10), Random.Range(-10,10 ), 0);
            Instantiate(_enemy, _enemyRoot.position + offset * 2, transform.rotation, transform);
            _enemies.Add(_enemy);
            _onSpawIsFinished.Invoke();

            _randomDelay = Random.value * 5;
            enemyCount--;
        }

        if (isFinished)
        {
            _onSpawIsFinished.Invoke();
        }
    }
}
