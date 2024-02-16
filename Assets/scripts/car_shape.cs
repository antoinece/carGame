using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class car_shape : MonoBehaviour
{

    [SerializeField] private GameObject _body;

     private LobbyProfile _profil;

    [SerializeField] private PlayerInput _playerInput;
    private int abcdefghijklmopqrstuwxyz=0;
    public void Setprofile(lobbySetup2 setup)
    {
        _profil = setup.profile;
        //shape shifting
        Destroy(_body);
        _body = Instantiate(_profil.Car,transform);
        // input re binding 
        Debug.Log(setup.Devices+"                  "+ _playerInput.currentControlScheme);
        if (abcdefghijklmopqrstuwxyz == 0)
        {
            _playerInput.SwitchCurrentControlScheme("keyboard", setup.Devices);
            abcdefghijklmopqrstuwxyz++;
        }else
        {
            _playerInput.SwitchCurrentControlScheme("Controler", setup.Devices);   
        }
        //_playerInput.SwitchCurrentControlScheme(setup.ControlScheme, setup.Devices);
        Debug.Log("set profile sucess");
        //if (_playerInput.currentControlScheme == "keyboard") ;
        //if  currentControlScheme  == keyboard
    }
}