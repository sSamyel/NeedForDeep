using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyCar : MonoBehaviour
{
    private GameObject _enemyCar;
    private float[] _enemyPosition = new float[3] {-2, 0, 2};
    private bool[] _enemyActive = new bool[3];

    private void Start()
    {
        _enemyCar = Resources.Load<GameObject>("EnemyCar");
    }

    public void SpawnEnemys()
    {
        RandomEnemyActive();

        for (int i = 0; i < 3; i++)
        {
            if (_enemyActive[i])
            {
                Instantiate(_enemyCar, new Vector3(_enemyPosition[i], 10f, 0), _enemyCar.transform.rotation);
            }
        }
    }

    private void RandomEnemyActive()
    {
        for (int i = 0; i < 3; i++)
        {
            _enemyActive[i] = Random.Range(0, 2) == 1; 
        }

        if (_enemyActive[0] && _enemyActive[1] && _enemyActive[2])
        {
            int randomIndex = Random.Range(0, 3); 
            _enemyActive[randomIndex] = false;
        }
    }
}
