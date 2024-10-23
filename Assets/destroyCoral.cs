using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyCoral : MonoBehaviour
{
    public string currentStringTarget;
    GameObject currentCoralTarget;
    public int x;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       for (int i = 0; i < currentStringTarget.Length; i++) {
            if (Input.GetButtonDown("first")) {
                x --;
                continue;
                
            }
            else {
                i=0;
            }
            //if input = char i in currentString:
                //continue
            //else:
                //i = 0
        } 
    }

    // boolean RecieveCode(String in, GameObject target)
    // {
    //     currentStringTarget = in;
    //     currentCoralTarget = target;

        

    //     // foreach (char c in currentStringTarget) {
    //     //     //if input = c:
    //     //         //continue
    //     //     //else: go to 0
    //     // }
    // }
}
