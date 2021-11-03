using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpTemplate : MonoBehaviour
{
    /// <summary>
    /// https://gamedevbeginner.com/how-to-change-a-sprite-from-a-script-in-unity-with-examples/
    /// Used to help me change sprites for my template arrows
    /// 
    /// </summary>
    [SerializeField] GameObject upArrow;
    public SpriteRenderer UpSpriteRenderer;
    public Sprite upWhiteSprite;
    public Sprite upBlackSprite;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ChangeSprite();
    }
    void ChangeSprite()
    {
        if (Input.GetKeyDown("up"))
        {
            UpSpriteRenderer.sprite = upWhiteSprite;
        }
        if (Input.GetKeyUp("up"))
        {
            UpSpriteRenderer.sprite = upBlackSprite;
        }
    }
}
