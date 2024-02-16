using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class hud : MonoBehaviour
{
    [SerializeField] private UIDocument _uiDocument;

    private Label _label;
    // Start is called before the first frame update
    void Start()
    {
        VisualElement panel = _uiDocument.rootVisualElement.Q("hud");
        if (panel != null)
        {
            _label = panel.Q("speed") as Label;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _label.text = Time.deltaTime.ToString();
    }
}
