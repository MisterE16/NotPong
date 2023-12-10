using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed;
    private bool theAI;
    private GameObject circle;

    private Rigidbody2D rigidBody;
    private Vector2 movePlayer;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();//dont have to define it as it will get it off the game object
    }

   
    void Update()
    {   //AI control
        if (theAI)
        {

        }
        //Player control
        else
        {

        }

        
    }

    private void PlayerControl()
    {
        
    }

    private void AiControl()
    {

    }
}
