using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneClick : MonoBehaviour 
{
    public GameObject prefabs;

    void OnClick()
    {
        Debug.Log(InputToEvent.inputHitPos);
        if(PhotonNetwork.connectionStateDetailed == ClientState.Joined)
        {
            PhotonNetwork.Instantiate(prefabs.name, InputToEvent.inputHitPos + new Vector3(0,3,0), Quaternion.identity, 0);
        }

    }


}
