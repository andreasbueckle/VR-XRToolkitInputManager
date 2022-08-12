using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[CreateAssetMenu(fileName = "NewKeyHandler")]
public class KeyHandler : InputHandler
{
    public KeyCode keyCode;
    public event Action<KeyCode> KeyDown;
    public event Action<KeyCode> KeyUp;

    public override void HandleState(XRController controller)
    {
        if (Input.GetKey(keyCode))
        {
            KeyDown?.Invoke(keyCode);
        }
    }
}
