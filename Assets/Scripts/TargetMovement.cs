using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotateSpeed;

    private void Start()
    {
        StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        while (true)
        {
            transform.position += transform.forward * _speed * Time.deltaTime;
            transform.Rotate(0, _rotateSpeed * Time.deltaTime, 0);

            yield return null;
        }
    }
}
