using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUNConnect : MonoBehaviour
{

    void Awake()
    {

    }

    void Start()
    {
        //连接同一个游戏的话，版本号要相同
        PhotonNetwork.ConnectUsingSettings("1.0");
    }

    void Update()
    {

    }

    private void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 75, 20, 150, 20), PhotonNetwork.connectionStateDetailed.ToString());

        if (GUI.Button(new Rect(Screen.width / 2 - 50, 50, 100, 30), "加入游戏房间"))
            if (PhotonNetwork.connected)
                PhotonNetwork.JoinOrCreateRoom("6666", new RoomOptions { maxPlayers = 4 }, null);

        if (GUI.Button(new Rect(Screen.width / 2 - 50, 100, 100, 30), "离开游戏房间"))
            if (PhotonNetwork.connected)
                PhotonNetwork.LeaveRoom();
    }

}
