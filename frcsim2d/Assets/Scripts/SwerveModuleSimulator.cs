using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveModuleSimulator : MonoBehaviour
{
    SwerveModule swerve;
    Transform RPMLog;
    string type;

    // Start is called before the first frame update
    void Start()
    {
        RPMLog = transform.Find("Pivot");
        type = name.Substring(0,2);

        if (type.Equals("FL")) {
          transform.position = new Vector3(SwerveMeta.xOffset, SwerveMeta.yOffset, 0);
        }
        else if (type.Equals("FR")) {
          transform.position = new Vector3(SwerveMeta.xOffset, -SwerveMeta.yOffset, 0);
        }
        else if (type.Equals("BL")) {
          transform.position = new Vector3(-SwerveMeta.xOffset, SwerveMeta.yOffset, 0);
        }
        else if (type.Equals("BR")) {
          transform.position = new Vector3(-SwerveMeta.xOffset, -SwerveMeta.yOffset, 0);
        }
        else {
          Debug.Log("Illegal swerve module detected!");
        }

        transform.eulerAngles = new Vector3(0,0,0);
        RPMLog.localScale = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
      if (type.Equals("FL")) {
        swerve = RobotState.state.frontLeft;
      }
      else if (type.Equals("FR")) {
        swerve = RobotState.state.frontRight;
      }
      else if (type.Equals("BL")) {
        swerve = RobotState.state.backLeft;
      }
      else if (type.Equals("BR")) {
        swerve = RobotState.state.backRight;
      }
      else {
        swerve = new SwerveModule();
      }

      transform.eulerAngles = new Vector3(0, 0, swerve.rotation);
      RPMLog.localScale = new Vector3(swerve.rpm/5,0.05f,1);
    }
}
