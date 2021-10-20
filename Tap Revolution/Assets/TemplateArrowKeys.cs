using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemplateArrowKeys : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left")) {

            print("left arrow key");

            //Below code destroys all template arrows
            //Destroy(gameObject);

            //Looking for code that destroys one template arrow... just to start off figuring out how to access
            //separate arrows
        }
        else if(Input.GetKeyDown("up")){
            print("up arrow key");
        }
        else if(Input.GetKeyDown("down")){
            print("down arrow key");

        }
        else if(Input.GetKeyDown("right")){
            print("right arrow key");

        }
    }
}
