using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteRoad : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.y < -16)
        {
            Destroy(gameObject);
        }
    }
}
