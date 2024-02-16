using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class lobbySetup2 : MonoBehaviour
{
    [SerializeField] private List<LobbyProfile> _profiles;
    [SerializeField] private GameObject _body;
    public int _playerIndex;
    private string _controlScheme;
    private InputDevice[] _devices;
    public int _modelIndex;
    private bool _ready=false;
    
    public bool Ready => _ready;
    public LobbyProfile profile => _profiles[_modelIndex];
    public InputDevice[] Devices => _devices;
    public string ControlScheme => _controlScheme;
    public int PlayerIndex => _playerIndex;
    
    public Action OnReady;
    
    private void Start()
    {
        LoadNewModel();
    }
    public void BindInputs(PlayerInput input)
    {
        _playerIndex = input.playerIndex;
        _controlScheme = input.currentControlScheme;
        _devices = input.devices.ToArray();
        Debug.Log(input.devices+"asdskdhjfjshfdgskjdhjfksajdhf");
    }

    void OnChangeModel(InputValue value)
    {
        float v = value.Get<float>();
        if (Mathf.Abs(v) == 1)
        {
            _modelIndex += Mathf.FloorToInt(v);

            if (_modelIndex < 0)
                _modelIndex = _profiles.Count - 1;
            if (_modelIndex > _profiles.Count - 1)
                _modelIndex = 0;
        }

        LoadNewModel();
    }

    void OnSelect(InputValue value)
    {
        _ready = true;
        OnReady?.Invoke();
    }

    private void LoadNewModel()
    {
        Destroy(_body);
        _body = Instantiate(_profiles[_modelIndex].Model, transform);
    }
}
