using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightArrowSpawner : MonoBehaviour
{
    [SerializeField] GameObject _RightArrowPrefab;
    float _ySpawn;
    // Start is called before the first frame update
    void Start()
    {
        _ySpawn = Camera.main.ViewportToWorldPoint(new Vector3(0, -.5f, 0)).y;
        InvokeRepeating("SpawnRightArrow", .5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRightArrow()
    {
        Instantiate(_RightArrowPrefab, new Vector3(2, _ySpawn, 0), Quaternion.identity);
    }
}
