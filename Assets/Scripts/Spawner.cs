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

    //private IEnumerator Start()
    //{
    //    var waiter = new WaitForSeconds(_spawnRate);
    //    while (true)
    //    {
    //        yield return waiter;
    //        Instantiate(_enemy, _enemyRoot);
    //    }
    //}

    float _lastSpawnDate;       // 20
    float _randomDelay;

    private void Update()
    {
        if (Time.time > _lastSpawnDate + _spawnRate + _randomDelay && enemyCount > 0)        // LSD = 25     Rate = 5            Time.time => 30
        {
            _lastSpawnDate = Time.time;

            Instantiate(_enemy, _enemyRoot);
            _enemies.Add(_enemy);

            _randomDelay = Random.value * 5;
            enemyCount--;
        }

        bool isFinished = true;
        //for (int i = 0; i < _enemies.Count; i++)
        //{
        //    if (_enemies[i] != null)
        //    {
        //        isFinished = false;
        //    }
        //}

        foreach (var item in _enemies)
        {
            if (item != null)
            {
                isFinished = false;
            }
        }
        if (isFinished)
        {
            _onSpawIsFinished.Invoke();
        }
    }




}
