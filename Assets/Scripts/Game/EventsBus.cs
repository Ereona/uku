using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EventsBus
{
    public static event Action<Vector3> MouseButtonDown;
    public static void RaiseMouseButtonDown(Vector3 arg)
    {
        MouseButtonDown?.Invoke(arg);
    }
}
