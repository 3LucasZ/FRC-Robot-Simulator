using System.Collections;
using System.Collections.Generic;

public class RobotState
{
  public static RobotData state = new RobotData();
}

[System.Serializable]
public class RobotData
{
    public SwerveModule frontLeft;
    public SwerveModule frontRight;
    public SwerveModule backLeft;
    public SwerveModule backRight;

    public float rotation;
    public float xVelocity;
    public float yVelocity;

    public RobotData() {
      frontLeft = new SwerveModule();
      frontRight = new SwerveModule();
      backLeft = new SwerveModule();
      backRight = new SwerveModule();

      rotation = 0;
      xVelocity = 0;
      yVelocity = 0;
    }
}

[System.Serializable]
public class SwerveModule
{
  public float rotation;
  public float rpm;

  public SwerveModule() {
    rotation = 0;
    rpm = 0;
  }
}
