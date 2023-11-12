using System.Collections;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _target;

    private void Start()
    {
        StartCoroutine(Move());
    }

    private void Update()
    {
        if (transform.position == _target.position)
        {
            Destroy(gameObject);
        }
    }

    private IEnumerator Move()
    {
        while (true)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
            yield return null;
        }
    }

    public void SetDirection(Transform target)
    {
        _target = target;
    }
}