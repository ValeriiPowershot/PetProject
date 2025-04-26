using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _playerSpeed = 5f;

    private bool _activated = false;
    private Vector3 _moveDirection;

    private void Update()
    {
        if (_activated) 
            transform.position += _moveDirection * _playerSpeed * Time.deltaTime;
    }

    public void PlayButtonClicked()
    {
        _activated = true;
        transform.SetParent(null);

        Vector2 directionToTarget = _target.position - transform.position;
        _moveDirection = -directionToTarget.normalized;
    }
}
