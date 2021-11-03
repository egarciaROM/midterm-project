using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownArrow : MonoBehaviour
{
    [SerializeField] GameObject _gameState;
    [SerializeField] float _speed = 12f;
    bool triggered = false;
    float _xPos = .65f;
    //float _yPos;
    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    /// <summary>
    /// https://stackoverflow.com/questions/52691474/detect-key-press-when-there-is-a-collision-trigger
    /// 
    /// 
    /// Helped me for below methods
    /// </summary>



    void Update()
    {
        transform.position += new Vector3(0, Time.deltaTime * _speed, 0);
        if (Input.GetKeyDown("down") && triggered)
        {
            GameState.Instance.IncreaseScore(50);
            Destroy(gameObject);

        }
        else if (Input.GetKeyDown("down") && !triggered) {
            GameState.Instance.DecreaseScore(5);
        }
        
        Despawn();

    }
    /// <summary>
    /// Midterm Milestone 2: Hamilton Gilbert
    /// Found the Despawn method and used it to destroy prefabs as they leave screen
    /// </summary>

    void Despawn()
    {
        if (transform.position.y > 5)
        {
            GameState.Instance.DecreaseScore(5);
            Destroy(gameObject);

        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Template")
        {
            triggered = true;
            
        }
        
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Template")
        {
            triggered = false;

        }
    }
}
