using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyCar : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - _speed * Time.deltaTime, transform.position.z);
    }
}
