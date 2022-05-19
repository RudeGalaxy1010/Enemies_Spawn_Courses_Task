using System.Collections;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private EnemyMoving _enemyPrefab;
    [SerializeField] private float _spawnDelay = 2f;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        int spawnPointIndex = Random.Range(0, _spawnPoints.Length);
        Instantiate(_enemyPrefab, _spawnPoints[spawnPointIndex].position, Quaternion.identity);
        yield return new WaitForSeconds(_spawnDelay);
        StartCoroutine(Spawn());
    }
}
