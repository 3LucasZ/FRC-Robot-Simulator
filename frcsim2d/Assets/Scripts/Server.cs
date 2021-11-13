using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using UnityEngine;

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
      mySock = new UdpClient(5000);
      while (true) {
        data = mySock.Receive(ref otherIPEP);
      }
    }).Start();
  }

  void Update()
  {
    if (data != null) {
      RobotState.state = JsonUtility.FromJson<RobotData>(data);;
    }
  }
}
