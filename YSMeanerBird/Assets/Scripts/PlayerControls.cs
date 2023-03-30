using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //Game manager object
    [Header("Game Controller Object for controlling the game")]
    public GameController gameController;
    [Header("Default Velocity")]
    public float velocity = 5;
    //physics for the bird
    private Rigidbody2D rb;
    //height of the bird object on the y axis
    private float objectHeight;
    // Start is called before the first frame update
    void Start()
    {
        //Game controller component
        gameController = GetComponent<GameController>();
        //speed for game
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
        //Object height
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //if left mouse button is clicked
        if  (Input.GetMouseButtonDown(0))
        {
            //bird will float up on Y and back down on Y
            rb.velocity = Vector2.up * velocity;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="HighSpike"
        || collision.gameObject.tag=="LowSpike"
        || collision.gameObject.tag=="Ground")
        {
           GameObject.Find("GameController").GetComponent<GameController>().GameOver();
        }
    }
}
