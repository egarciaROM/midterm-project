using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftTemplate : MonoBehaviour
{
    /// <summary>
    /// https://gamedevbeginner.com/how-to-change-a-sprite-from-a-script-in-unity-with-examples/
    /// Used to help me change sprites for my template arrows
    /// 
    /// </summary>
    [SerializeField] GameObject leftArrow;
    public SpriteRenderer LeftSpriteRenderer;
    public Sprite leftWhiteSprite;
    public Sprite leftBlackSprite;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeSprite();
    }
    void ChangeSprite() {
        if (Input.GetKeyDown("left")) {
            LeftSpriteRenderer.sprite = leftWhiteSprite;
        }
        if (Input.GetKeyUp("left")) {
            LeftSpriteRenderer.sprite = leftBlackSprite;
        }
    }
}
