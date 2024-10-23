using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breath : MonoBehaviour
{
    public float timeToDrown = 60.0f;
    bool isTimerPaused = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimerPaused == false) {
            timeToDrown -= Time.deltaTime;
        }
    }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.collider.name == "ocean") {
            isTimerPaused = false; //unpasue timer/start countdown again
        }
    }

    void OnCollisionExit2D(Collision2D col) {
        if (col.collider.name == "ocean") {
            isTimerPaused = true; //pause timer/stop countdown
        }
    }
}
