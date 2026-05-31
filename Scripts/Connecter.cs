using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class Connecter : MonoBehaviourPunCallbacks 
{
    // Start is called before the first frame update  
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    // Called when the client is connected to the Master Server  
    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("Menu");
    }
}
