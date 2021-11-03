using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightTemplate : MonoBehaviour
{
    /// <summary>
    /// https://gamedevbeginner.com/how-to-change-a-sprite-from-a-script-in-unity-with-examples/
    /// Used to help me change sprites for my template arrows
    /// 
    /// </summary>


    [SerializeField] GameObject rightArrow;
    public SpriteRenderer RightSpriteRenderer;
    public Sprite rightWhiteSprite;
    public Sprite rightBlackSprite;


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
        if (Input.GetKeyDown("right")) {
            RightSpriteRenderer.sprite = rightWhiteSprite;
        }
        if (Input.GetKeyUp("right")) {
            RightSpriteRenderer.sprite = rightBlackSprite;
        }
    }
}
