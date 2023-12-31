﻿using UnityEngine;
using System.Collections;
using System;
using CustomCollisionDetection;

public class AreaCollisionExp2 : AreaManager
{
    protected override void OnOverlap(Action<object> action)
    {
        Action<object> act = action;
        if (act != null) {
            useAutoCallBack = false;
            act(color);
        }
    }
}