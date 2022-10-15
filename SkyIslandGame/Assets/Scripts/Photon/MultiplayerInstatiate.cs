using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class MultiplayerInstatiate : MonoBehaviour
{
    private void Awake()
    {
        GameObject testPlayer = PhotonNetwork.Instantiate("TestPlayer", Vector3.zero, transform.rotation);
    }
}
