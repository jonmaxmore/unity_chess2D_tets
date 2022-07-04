using Firesplash.UnityAssets.SocketIO;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


#if HAS_JSON_NET
//If Json.Net is installed, this is required for Example 6. See documentation for information on how to install Json.NET
//Please note that most recent unity versions bring Json.Net with them by default, you would only need to enable the compiler flag as documented.
using Newtonsoft.Json;
#endif


public class GameManagerScript : MonoBehaviour
{
    public SocketIOCommunicator socket;

    void Start()
    {
        socket = SocketManager.Instance.GetSocketIOComponent();

        socket.Instance.On("connect", (string data) =>
        {
            Debug.Log("LOCAL: Hey, we are connected!");
        });

        socket.Instance.Connect();

    }
}
