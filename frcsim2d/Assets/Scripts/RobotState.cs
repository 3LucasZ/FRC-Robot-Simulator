using System.Collections;
using System.Collections.Generic;

public class RobotState
{
  public static RobotData state = new RobotData();
}

[System.Serializable]
public class RobotData
{
    public SwerveModule leftTop;
    public SwerveModule leftBack;
    public SwerveModule rightTop;
    public SwerveModule rightBack;
    public float rotation;
    public float xVelocity;
    public float yVelocity;
    public RobotData() {
      leftTop = new SwerveModule("lt");
      leftBack = new SwerveModule("lb");
      rightTop = new SwerveModule("rt");
      rightBack = new SwerveModule("rb");
      rotation = 0;
      xVelocity = 0;
      yVelocity = 0;
    }
}

[System.Serializable]
public class SwerveModule
{
  public string type;
  public float rotation;
  public float rpm;

  public SwerveModule(string t) {
    type = t;
    rotation = 0;
    rpm = 0;
  }
}
