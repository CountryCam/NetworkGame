using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class RpcTest : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public override void OnNetworkSpawn()
    {
        if(IsOwner && !IsHost)
        {
            Debug.Log("FIRING RPC!");
            TestHostServerRpc(100);
        }
    }

    [ServerRpc]

    void TestHostServerRpc(int value)
    {
        Debug.Log($"Host Recieved RPC #{value}");
        TestClientRpc(value + 1);
    }

    [ClientRpc]

    void TestClientRpc(int value)
    {
        Debug.Log($"Client Recieved RPC #{value}");
    }
}
