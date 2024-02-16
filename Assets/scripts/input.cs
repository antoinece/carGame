using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputsValue : MonoBehaviour
{
    [SerializeField]
    public bool w = false;
    [SerializeField]
    public bool s = false;
    [SerializeField]
    public bool a = false;
    [SerializeField]
    public bool d = false;
    [SerializeField]
    public bool drift = false;
    
    
    
    public void OnAccelerate(InputValue value)
    {
        w = value.isPressed;
    }
    public void OnBreak(InputValue value)
    {
        s = value.isPressed;
    }
    public void OnLeft(InputValue value)
    {
        a = value.isPressed;
    }
    public void OnRight(InputValue value)
    {
        d = value.isPressed;
    }
    public void OnDrift(InputValue value)
    {
        drift = value.isPressed;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
