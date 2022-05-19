using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector2 _targetPosition = Vector2.zero;

    void Update()
    {
        if ((Vector2)transform.position != _targetPosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, _targetPosition, Time.deltaTime * _speed);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
