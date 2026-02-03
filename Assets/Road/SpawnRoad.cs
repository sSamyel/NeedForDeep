using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnRoad : MonoBehaviour
{
    [SerializeField] private GameObject _newRoad;
    [SerializeField] private SpawnEnemyCar _enemysCar;

    private Vector3 _roadPosition = new Vector3 (0, 11.6f, 0);
    private bool _isSpawning = false;

    private void Update()
    {
        if (transform.position.y <= -4 && !_isSpawning)
        {
            Instantiate(_newRoad, _roadPosition, Quaternion.identity);
            _enemysCar.SpawnEnemys();
            _isSpawning = true;
        }
    }
}
