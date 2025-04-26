using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotator : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 100f;
    
    [SerializeField] private bool _isRotating;
    [SerializeField] private bool _leftRotating;

    private void Update()
    {
        if (!_isRotating) return;
        
        
        float direction = _leftRotating ? 1f : -1f;
        transform.Rotate(0f, 0f, direction * _rotationSpeed * Time.deltaTime);
    }
}
