using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _resetPositionX = -20f;
    [SerializeField] private float _startPositionX = 20f;

    private void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;

        if (transform.position.x <= _resetPositionX)
        {
            Vector3 pos = transform.position;
            pos.x = _startPositionX;
            transform.position = pos;
        }
    }
}
