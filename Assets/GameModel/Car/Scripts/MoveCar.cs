using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveCar : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _stop = 2.6f;

    private float _direction;

    public void MoveInput(InputAction.CallbackContext context)
    {
        _direction = context.ReadValue<float>();
    }

    private void Update()
    {
        var newPosition = transform.position.x + _direction * _speed * Time.deltaTime;

        if (Mathf.Abs(newPosition) < _stop)
        {
            transform.position = new Vector3(newPosition, transform.position.y, transform.position.z);
        }

    }
}
