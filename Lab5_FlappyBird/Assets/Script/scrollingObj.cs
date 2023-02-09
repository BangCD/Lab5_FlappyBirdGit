using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollingObj : MonoBehaviour
{
    private Rigidbody2D platformRB;

    PlayerMovement playerMovement;

    //[SerializeField] private float platformSpeed;

    // Start is called before the first frame update
    void Start()
    {
        platformRB= GetComponent<Rigidbody2D>();
        platformRB.velocity = new Vector2(gameController.instance.scrollSpeed, 0);



    }

    // Update is called once per frame
    void Update()
    {
        if (gameController.instance.gameOver==true) 
        {
            platformRB.velocity = Vector2.zero;
        }
    }
}
