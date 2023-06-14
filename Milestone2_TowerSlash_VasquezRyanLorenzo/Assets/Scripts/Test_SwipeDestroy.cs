using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_SwipeDestroy : MonoBehaviour
{
    //To save where player touched thing
    private Vector2 initialTouchPosition;
    private Vector2 endTouchPosition;
    bool hasCollided = false;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        //Destroy(other.gameObject);
        hasCollided = true;

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Touch touch = Input.GetTouch(0);
            initialTouchPosition = touch.position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            Touch touch = Input.GetTouch(0);
            endTouchPosition = touch.position;

            CheckSwipe();
        }

        if (hasCollided == true)
        {
            Debug.Log("COLLIDED");
        }
    }

    private void CheckSwipe()
    {

        //Probs based on Eclidean Plane, right is positive & left is negative
        if (initialTouchPosition.x < endTouchPosition.x && hasCollided == true)
        {
            //debugText.text = "Swiped Right";
            Debug.Log("Entity Destroyed");
            Destroy(gameObject);
        }
        else
        {
            //debugText.text = "Swiped Left";

        }
    }
}
