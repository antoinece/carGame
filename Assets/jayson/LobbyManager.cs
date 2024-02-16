// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.InputSystem;
// using UnityEngine.SceneManagement;
//
// public class LobbyManager : MonoBehaviour
// {
//
//     private List<lobbySetup> _joinedSetups = new List<lobbySetup>();
//     [SerializeField] private List<Transform> _spawnpoint;
//     
//     public void OnPlayerJoined(PlayerInput input)
//     {
//         Debug.Log("player join : " + input.playerIndex + ":"
//                   + input.gameObject + ":" + input.currentControlScheme
//                   + ":" + input.devices);
//
//
//         if (input.gameObject.TryGetComponent<lobbySetup>(out var setup))
//         {
//             setup.gameObject.transform.position = _spawnpoint[input.playerIndex].position;
//             setup.BindInputs(input);
//             setup.OnReady += checkEveryoneisready;
//             _joinedSetups.Add(setup);
//             
//             DontDestroyOnLoad(setup);
//         }
//     }
//
//     private void checkEveryoneisready()
//     {
//         if (_joinedSetups.Count < 2)
//             return;
//         bool everyoneIsReady = true;
//         
//         
//         foreach (lobbySetup setup in _joinedSetups)
//         {
//             if (!setup.Ready)
//                 everyoneIsReady = false;
//         }
//
//         if (everyoneIsReady)
//         {
//             foreach ( lobbySetup setup in _joinedSetups)
//             {
//                 setup.gameObject.SetActive(false);
//             }
//             SceneManager.LoadScene("game");
//         }
//             
//     }
//
//    
// }
