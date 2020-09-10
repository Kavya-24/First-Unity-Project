using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Mono behaviour gives update of what is happening in the enivronment
//How many frames passed, current condition(state) of the cube
//We can access the tranform, rotate and translate extra behaviours from this

public class move : MonoBehaviour
{

    //AWAKE > ENABLE > START        (Guided by mono-behaviour)

    //Default is 0
    public int value;

    void Awake(){
        Debug.Log("In awake value is" + value);
        value++;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start value is " + value);
        value++;
    }


    void OnEnable(){
        Debug.Log("Enable is " + value);
        value++;
    }
    
    // Update is called once per frame
    // Increment value depends on fps
    //Tells the scene that ut is ready for rendering
    // The estimation of fps is wrt that the camera takes x (fps = x) pictures per second

    //For example, we tell a camera that we are about to take a photo, make your changes
    void Update()
    {
     
        //Transform
        
        //Horizontal
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
         transform.position = transform.position + new Vector3(-2f, 0, 0);
        }

        if(Input.GetKeyDown(KeyCode.RightArrow)){
            transform.position = transform.position + new Vector3(2f, 0, 0);
        }

        //Vertical
        if(Input.GetKeyDown(KeyCode.UpArrow)){
         transform.position = transform.position + new Vector3(0, 2f, 0);
        }

        if(Input.GetKeyDown(KeyCode.DownArrow)){
            transform.position = transform.position + new Vector3(0, -2f, 0);
        }

        //In Z
        if(Input.GetKeyDown(KeyCode.N)){
         transform.position = transform.position + new Vector3(0, 0, 2f);
        }

        if(Input.GetKeyDown(KeyCode.M)){
            transform.position = transform.position + new Vector3(0, 0, -2f);
        }

    }

    //For example, unity tells us that the photo has been taken, now what you want to do
    private void LateUpdate(){

    } 
}
