using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class LobbyManager2 : MonoBehaviour
{
    private List<lobbySetup2> _joinedSetups= new List<lobbySetup2>();
    [SerializeField]private List<Transform> _spawnPoints;
    private bool player1 = true;
    private int Player1 = 0;
    private int Player2 = 0;
    public void OnPlayerJoined(PlayerInput input)
    {
        Debug.Log("player join : " + input.playerIndex + ":"
                  + input.gameObject + ":" + input.currentControlScheme
                  + ":" + input.devices);


        if (input.gameObject.TryGetComponent<lobbySetup2>(out var setup))
        {
            setup.gameObject.transform.position = _spawnPoints[input.playerIndex].position;
            setup.BindInputs(input);
            setup.OnReady += isEvryoneReady;
            _joinedSetups.Add(setup);
            
           // DontDestroyOnLoad(setup);
        }
    }
    
    
    private void isEvryoneReady()
    {

        
        
        bool evryoneReady = true;

        foreach (lobbySetup2 setup in _joinedSetups)
        {
            if (!setup.Ready)
                evryoneReady = false;

            if (setup._playerIndex==0)
                Player1 = setup._modelIndex;
            else
                Player2 = setup._modelIndex;
            Debug.Log(Player1+"           "+Player2);
        }

        if (evryoneReady)
        {
            SceneManager.LoadScene("Track_A");
            if (Player1==0 && Player2==0)
                SceneManager.LoadScene("BB", LoadSceneMode.Additive);
            
            if (Player1==0 && Player2==1)
                SceneManager.LoadScene("BR", LoadSceneMode.Additive);
            
            if (Player1==1 && Player2==0)
                SceneManager.LoadScene("RB", LoadSceneMode.Additive);
            
            if (Player1==1 && Player2==1)
                SceneManager.LoadScene("RR", LoadSceneMode.Additive);
        }
    }
}
