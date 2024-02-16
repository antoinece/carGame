using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(menuName = "carDatas/lobbyprofile",fileName = "profille")]
public class LobbyProfile : ScriptableObject
{
    public GameObject Model;
    [FormerlySerializedAs("modelSprite")] public GameObject Car;
    
}
