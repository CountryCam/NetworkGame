using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Netcode;


public class PlayerManager :NetworkBehaviour
{
    public static PlayerManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        if (IsOwner)
        {
            Debug.Log("IsHost : " + IsHost + " IsClient : " + IsClient);
            ConnectionManager.Instance.UpdateFlags(IsHost, IsClient);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
