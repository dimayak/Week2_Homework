using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Скорость перемещения
    [SerializeField] private float _movementSpeed = 5;
    // Ускорение
    [SerializeField] private float _sprintSpeedModifier = 3.0f;
    // Скорость вращения
    [SerializeField] private float _rotationSpeed = 200;


    void Update()
    {
        HandleMovement();
        HandleRotation();
    }

    private void HandleMovement()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        float sprintCoeff = 1.0f;
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            sprintCoeff = _sprintSpeedModifier;
        }

        Vector3 offset = new Vector3(h, 0, v) * _movementSpeed * sprintCoeff * Time.deltaTime;
        transform.Translate(offset);
    }

    private void HandleRotation()
    {
        float yRotation = Input.GetAxis("Mouse X");
        transform.Rotate(0, yRotation * _rotationSpeed * Time.deltaTime, 0);
    }
}
