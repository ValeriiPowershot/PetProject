using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _objectPrefab;
    [SerializeField] private int _numberOfObjects = 5;
    [SerializeField] private float _radius = 5f;
    [SerializeField] private CircleCollider2D _circleCollider2D;

    private void Start()
    {
        SpawnObjectsAround();
    }

    private void SpawnObjectsAround()
    {
        _circleCollider2D.radius = _radius;
        
        for (int i = 0; i < _numberOfObjects; i++)
        {
            float angle = i * Mathf.PI * 2f / _numberOfObjects;

            Vector3 position = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0f) * _radius + transform.position;

            GameObject spawnedObject = Instantiate(_objectPrefab, position, Quaternion.identity);
            spawnedObject.transform.SetParent(transform);  
        }
    }
}
