using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArrowSpawner : MonoBehaviour
{
    [SerializeField] GameObject _LeftArrowPrefab;
    float _ySpawn;
    // Start is called before the first frame update
    void Start()
    {
        _ySpawn = Camera.main.ViewportToWorldPoint(new Vector3(0, -.5f, 0)).y;


        InvokeRepeating("SpawnLeftArrow", 0, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnLeftArrow()
    {
        Instantiate(_LeftArrowPrefab, new Vector3(-2, _ySpawn, 0), Quaternion.identity);
    }
}
