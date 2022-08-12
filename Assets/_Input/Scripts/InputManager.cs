using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InputManager : MonoBehaviour
{
    public List<ButtonHandler> allButtonHandlers = new List<ButtonHandler>();
    public List<AxisHandler2D> allAxisHandlers2D = new List<AxisHandler2D>();
    public List<AxisHandler> allAxisHandlers = new List<AxisHandler>();
    public List<KeyHandler> allKeyHandlers = new List<KeyHandler>();

    private XRController controller = null;

    private void Awake()
    {
        controller = GetComponent<XRController>();
    }

    private void Update()
    {
        HandleButtonEvents();
        HandleAxisEvents();
        HandleAxis2DEvents();
        HandleKeyEvents();
    }

    private void HandleButtonEvents()
    {
        foreach (ButtonHandler Handler in allButtonHandlers)
        {
            Handler.HandleState(controller);
        }
    }

    private void HandleKeyEvents()
    {
        foreach (KeyHandler handler in allKeyHandlers)
        {
            handler.HandleState(controller);
        }
    }

    private void HandleAxis2DEvents()
    {
        foreach (AxisHandler handler in allAxisHandlers)
        {
            handler.HandleState(controller);
        }
    }

    public void HandleAxisEvents()
    {
        foreach (AxisHandler2D handler in allAxisHandlers2D)
        {
            handler.HandleState(controller);
        }
    }
}

