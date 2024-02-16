using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.Serialization;

public class Camera : MonoBehaviour
{

    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    [SerializeField] private CinemachineVirtualCamera zoomedIn;
    [SerializeField] private CinemachineVirtualCamera zoomedOut;

    [SerializeField] public bool zoomOn;
    [SerializeField] private float playerZDifference;
    [SerializeField] private float playerXDifference;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerZDifference = (player1.gameObject.transform.position.z - player2.gameObject.transform.position.z);
        playerXDifference = (player1.gameObject.transform.position.x - player2.gameObject.transform.position.x);
        if (playerXDifference is < 50 and > -50 && playerZDifference is < 50 and > -50)
        {
            zoomOn = true;
            zoomedIn.m_Priority = 10;
            zoomedOut.m_Priority = 1;
        }
        else
        {
            zoomOn = false;
            zoomedIn.m_Priority = 1;
            zoomedOut.m_Priority = 10;
        }
    }
}
