using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownArrowSpawner : MonoBehaviour
{
    [SerializeField] GameObject _DownArrowPrefab;
    float _ySpawn;
    // Start is called before the first frame update
    void Start()
    {
        _ySpawn = Camera.main.ViewportToWorldPoint(new Vector3(0, -.5f, 0)).y;
        InvokeRepeating("SpawnDownArrow", 1.5f, 1.25f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnDownArrow()
    {
        Instantiate(_DownArrowPrefab, new Vector3(.65f, _ySpawn, 0), Quaternion.identity);
    }
}
