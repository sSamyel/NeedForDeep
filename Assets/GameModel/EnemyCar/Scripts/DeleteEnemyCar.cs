using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteEnemyCar : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.y < -9)
        {
            Destroy(gameObject);
        }
    }
}
