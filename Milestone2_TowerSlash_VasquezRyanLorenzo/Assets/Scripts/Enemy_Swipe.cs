using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy_Swipe : MonoBehaviour
{
    //To save where player touched thing
    private Vector2 initialTouchPosition;
    private Vector2 endTouchPosition;
    bool hasCollided = false;
    public bool isLeft; //default false
    public bool isRight; //default false

    public int num = 0;

    public DashGauge dashGauge;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        hasCollided = true;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > num && Input.GetTouch(num).phase == TouchPhase.Began)
        {
            Touch touch = Input.GetTouch(num);
            initialTouchPosition = touch.position;
        }

        if (Input.touchCount > num && Input.GetTouch(num).phase == TouchPhase.Ended)
        {
            Touch touch = Input.GetTouch(num);
            endTouchPosition = touch.position;

            CheckSwipe();
        }


    }
    private void CheckSwipe()
    {
        //Probs based on Eclidean Plane, right is positive & left is negative
        if (initialTouchPosition.x > endTouchPosition.x && hasCollided == true && isLeft == true)
        {
            Destroy(gameObject);

            //This calls in the ActivatePowerUp() from Enemy for this script
            //This looks at GameComponents
            this.GetComponent<Enemy>().ActivatePowerUp();

            dashGauge.addDashMeter();
            SpawnerManager.Instance.RemoveEnemyFromList(gameObject);

        }

        //Probs based on Eclidean Plane, right is positive & left is negative
        if (initialTouchPosition.x < endTouchPosition.x && hasCollided == true && isRight == true)
        {
            Destroy(gameObject);
        }
    }
    private bool PointIsOnLeft(Vector2 point1, Vector2 point2, Vector2 point3)
    {
        return (point2.x - point1.x) * (point3.y - point1.y) - (point2.y - point1.y) * (point3.x - point1.x) > 0;
    }
}
