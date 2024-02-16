using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class spawner : MonoBehaviour
{

    [SerializeField] private GameObject _prefab;
    [SerializeField] private List<Transform> _spawnpoint;
    
        private void Start()
        {
            List<lobbySetup2> setups = FindObjectsByType<lobbySetup2>(FindObjectsInactive.Include,FindObjectsSortMode.None).ToList();


            for (int i = 0; i < setups.Count; i++)
            {
                Debug.Log("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
                Transform t = _spawnpoint[i % _spawnpoint.Count];
                GameObject newcar = Instantiate(_prefab,t.position,t.rotation);

                if (newcar.TryGetComponent<car_shape>(out var shape))
                {
                    shape.Setprofile(setups[i]);
                }
                setups[i].gameObject.SetActive(false);
            }
        }
        
        public void OnPlayerJoined(PlayerInput input)
        {
            Debug.Log("player " + input.playerIndex + "name " + input.gameObject.name + "device " + input.devices[0]) ;
            
        }
    
}
