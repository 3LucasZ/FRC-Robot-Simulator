using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

public class Server : MonoBehaviour
{
  UdpClient mySock;
  IPEndPoint otherIPEP;

  byte[] data;

  void Start()
  {
    otherIPEP = new IPEndPoint(IPAddress.Any, 5000);
    new Thread (() =>
    {
      mySock = new UdpClient(6000);
      while (true) {
        data = mySock.Receive(ref otherIPEP);
      }
    }).Start();
  }

  void Update()
  {
    if (data != null) {
      string jsonData = System.Text.Encoding.ASCII.GetString(data);
      RobotState.state = JsonUtility.FromJson<RobotData>(jsonData);
    }
  }
}
