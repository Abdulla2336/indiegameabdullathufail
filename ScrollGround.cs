using UnityEngine;

public class ScrollGround : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _tileWidth = 20f;

    private void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;

        if (transform.position.x <= -_tileWidth)
        {
            transform.position += Vector3.right * (_tileWidth * 2f);
        }
    }
}
