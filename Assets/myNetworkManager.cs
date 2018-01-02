﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class myNetworkManager : NetworkManager {

    public override void OnStartHost()
    {
        base.OnStartHost();
        Debug.Log(Time.timeSinceLevelLoad + "Host requested");
    }

    public override void OnStartClient(NetworkClient myClient)
    {
        base.OnStopClient();
        Debug.Log(Time.timeSinceLevelLoad + " Client start requested" );
    }
}