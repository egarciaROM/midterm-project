using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpArrowSpawner : MonoBehaviour
{
    [SerializeField] GameObject _UpArrowPrefab;
    float _ySpawn;
    // Start is called before the first frame update
    void Start()
    {
        _ySpawn = Camera.main.ViewportToWorldPoint(new Vector3(0, -.5f, 0)).y;
        InvokeRepeating("SpawnUpArrow", 1, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnUpArrow()
    {
        Instantiate(_UpArrowPrefab, new Vector3(-.65f, _ySpawn, 0), Quaternion.identity);
    }
}
