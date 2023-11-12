using System.Collections;
using System.Collections.Generic;
using Unity.Netcode.Components;
using UnityEngine;
using Unity.Netcode;


public class NetworkManagement : NetworkBehaviour
{
    public static NetworkVariable<bool> isImposterAsigned = new NetworkVariable<bool>(false, NetworkVariableReadPermission.Everyone);
    
}
