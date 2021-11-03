using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownTemplate : MonoBehaviour
{
    /// <summary>
    /// https://gamedevbeginner.com/how-to-change-a-sprite-from-a-script-in-unity-with-examples/
    /// Used to help me change sprites for my template arrows
    /// 
    /// </summary>
    
    [SerializeField] GameObject downArrow;
    public SpriteRenderer DownSpriteRenderer;
    public Sprite downWhiteSprite;
    public Sprite downBlackSprite;


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
        if (Input.GetKeyDown("down"))
        {
            DownSpriteRenderer.sprite = downWhiteSprite;
        }
        if (Input.GetKeyUp("down"))
        {
            DownSpriteRenderer.sprite = downBlackSprite;
        }
    }
}
