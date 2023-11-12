using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private EnemyMovement _enemy;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        var delayBeforeSpawn = new WaitForSeconds(6);

        while (true)
        {
            var enemy = Instantiate(_enemy, transform.position, Quaternion.identity);
            enemy.SetDirection(_target);
            yield return delayBeforeSpawn;
        }
    }
}