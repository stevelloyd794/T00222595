using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class charactercontrol : MonoBehaviour
{

    float currentSpeed, walkingSpeed = 2, runningSpeed = 4;
    private float turningspeed = 180;
    Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = walkingSpeed;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
            myAnimator.SetBool("isWalking", true);
            transform.position += currentSpeed * transform.forward * Time.deltaTime;
    }
    {
          if (Input.GetKey(KeyCode.S)

            transform.position -= currentSpeed* transform.forward* Time.deltaTime;

}

}
