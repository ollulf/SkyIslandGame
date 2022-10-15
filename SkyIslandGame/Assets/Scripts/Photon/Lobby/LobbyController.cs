using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class LobbyController : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameObject loginButton;
    [SerializeField] private TextMeshProUGUI textInput;
    [SerializeField] private int roomSize;


    public void OnClickLogin()
    {
        if(textInput.text != null)
        {
            PhotonNetwork.LocalPlayer.NickName = textInput.text;
            PhotonNetwork.JoinRandomRoom();
            Debug.Log("Entering Room");
        }
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.LogError("Failed to join Room: " + returnCode + message);
        CreateRoom();
    }

    private void CreateRoom()
    {
        Debug.Log("Creating room now");
        int randomRoomNumber = Random.Range(0, 10000);
        RoomOptions roomOps = new RoomOptions() { IsVisible = true, IsOpen = true, MaxPlayers = (byte)roomSize };
        PhotonNetwork.CreateRoom("Room" + randomRoomNumber, roomOps);
        Debug.Log(randomRoomNumber);
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Failed to create room... trying again: " + returnCode + message);
        CreateRoom();
    }
}
