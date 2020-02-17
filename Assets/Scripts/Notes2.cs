using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //this line is needed to reference UI items like buttons or images 
using UnityEngine.SceneManagement; //this calls the scene manager which loads levels(scenes) 
using UnityEngine.Audio; 

public class Notes2 : MonoBehaviour
{
    public Image myImage;
    public Button myButton; 
    public float timer
    // Start is called before the first frame update
    //Olivia Pavucek 

    //TIMERS 
    //we can create timers using the command Time.deltaTime this means the time since the last frame ended 
    //generally we take a float and we add or subtract Time.deltaTime to make a timer 

    //AI 
    //MOVE TOWARDS 
    //Vector3.MoveTowards is a command that will move one gameObject towards another one 
    //MoveTowards needs 3 things 
    //our current location (Vector 3) 
    //A target location (Vector 3)  
    //How long it will take to move from point a to point b (usually we set this as a number) 
    public Vector3 Start;
    public Vector3 Finish;
    public float speed;
    public GameObject target; //this is another gameobject that we want to follow 

    //INSTANTIATE is a way to make things appear, this could be enemies or loot that enemies drop 
    public GameObject money; //this os usually a prefab in the assets folder thayt we will bring into our scene 

    void Start()
    {
        Start = transform.position; //this sets our position to the start position 
        Finish = target.transform.position; //this gets the targets position 

        GameObject loot=Instantiate(money, transform.position, transform.rotation) 
            //this above line will bring loot into existance at this location and rotation 
            Destroy(money, 5f) //this line gets rid of our instantiated prefab "money" 
            //Instantiate and destroy will cause garbage to accumulate so NOT mobile friendly 
            //AUTOPOOLING
        GameObject loot2 = MF_Autopool.spawn(moneyt, transform.position, transform.rotation);
        MF_Autopool
    }

    // Update is called once per frame
    void Update()
    {
        //TIMER 
        timer -= timer.deltaTime; //this will subtract from the timer every frame 
        timer += timer.deltaTime; //this will add to the timer every frame; 
                                  //usually you run one or the other 
        Finish = target.transform.position;//this gets the targets position in real time

        //MOVE TOWARDS 
        Vector3.MoveTowards(Start, Finish, speed); //usually start is the enemy location and finish is the player location     speed is constant 

        
    }





}
