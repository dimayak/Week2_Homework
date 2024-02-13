using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 5;
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

        Vector3 offset = new Vector3(h, 0, v) * _movementSpeed * Time.deltaTime;
        transform.Translate(offset);
    }

    private void HandleRotation()
    {
        float yRotation = Input.GetAxis("Mouse X");
        transform.Rotate(0, yRotation * _rotationSpeed * Time.deltaTime, 0);
    }
}
