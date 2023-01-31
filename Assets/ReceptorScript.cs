using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ReceptorScript : MonoBehaviour
{
    public logicScript logic;
    public BoxCollider2D myBoxCollider;

    private Collider2D currentArrowCollided;
    private bool arrowIsCaught = false;
    private bool arrowIsCatchable = false;


    private void Start()
    {
    logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    private void Update()
    {

        if (arrowIsCatchable)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) && currentArrowCollided.CompareTag("Up"))
            {
                arrowIsCaught = true;
            }

            if (Input.GetKeyDown(KeyCode.RightArrow) && currentArrowCollided.CompareTag("Right"))
            {
                arrowIsCaught = true;
            }

            if (Input.GetKeyDown(KeyCode.DownArrow) && currentArrowCollided.CompareTag("Down"))
            {
                arrowIsCaught = true;
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow) && currentArrowCollided.CompareTag("Left"))
            {
                arrowIsCaught = true;
            }
        }

        if (arrowIsCaught)
        {
            Destroy(currentArrowCollided.gameObject);
            logic.addScore();
            arrowIsCatchable = false;
            arrowIsCaught = false;
        }
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        currentArrowCollided = collision;
        arrowIsCatchable = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        arrowIsCatchable = false;
    }
}