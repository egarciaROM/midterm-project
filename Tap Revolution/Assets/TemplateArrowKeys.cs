using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemplateArrowKeys : MonoBehaviour
    
{
    [SerializeField] GameObject leftArrow;
    [SerializeField] GameObject rightArrow;
    [SerializeField] GameObject upArrow;
    [SerializeField] GameObject downArrow;
    public SpriteRenderer spriteRender;
    public Sprite[] whiteSprite;
    public Sprite[] blackSprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    /*
     * SPRITE CHANGES BELOW ARE LEARNED FROM THIS TUTORIAL WEBPAGE
     * https://gamedevbeginner.com/how-to-change-a-sprite-from-a-script-in-unity-with-examples/
     * 
     */


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left")) {

            print("left arrow key");
            spriteRender.sprite = whiteSprite[1];
            
        }
        if(Input.GetKeyDown("up")){
            print("up arrow key");
            spriteRender.sprite = whiteSprite[3];
            
        }
        if(Input.GetKeyDown("down")){
            print("down arrow key");

            spriteRender.sprite = whiteSprite[0];
            

        }
        if(Input.GetKeyDown("right")){
            print("right arrow key");

            spriteRender.sprite = whiteSprite[2];
            

        }
        if (Input.GetKeyUp("left"))
        {

            print("left arrow key up");
            spriteRender.sprite = blackSprite[1];
            
        }
        if (Input.GetKeyUp("up"))
        {
            print("up arrow key up");
            spriteRender.sprite = blackSprite[3];
            
        }
        if (Input.GetKeyUp("down"))
        {
            print("down arrow key up");

            spriteRender.sprite = blackSprite[0];
            

        }
        if (Input.GetKeyUp("right"))
        {
            print("right arrow key up");

            spriteRender.sprite = blackSprite[2];
            

        }
    }
}
