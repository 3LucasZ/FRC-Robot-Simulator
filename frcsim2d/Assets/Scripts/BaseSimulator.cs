using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSimulator : MonoBehaviour
{
    void Start()
    {
      transform.position = new Vector3(0,0,0);
      transform.eulerAngles = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
      transform.position = transform.position + new Vector3(RobotState.state.xVelocity/10000, RobotState.state.yVelocity/10000, 0);
      transform.eulerAngles = new Vector3(0, 0, RobotState.state.rotation);
    }
}
