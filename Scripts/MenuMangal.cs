using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class MenuMangal : MonoBehaviourPunCallbacks
{
    public InputField createInputField;
    public InputField joinInputField;
    // Start is called before the first frame update
    public void CreateRoom()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 4;
        PhotonNetwork.CreateRoom(createInputField.text, roomOptions);
    }
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInputField.text);
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }

}
