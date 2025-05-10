using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _pipePrefab;
    [SerializeField] private float _spawnInterval = 1.5f;
    [SerializeField] private float _heightRange = 1f;

    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _spawnInterval)
        {
            Vector3 spawnPos = transform.position;
            spawnPos.y += Random.Range(-_heightRange, _heightRange);
            Instantiate(_pipePrefab, spawnPos, Quaternion.identity);
            _timer = 0;
        }
    }
}
