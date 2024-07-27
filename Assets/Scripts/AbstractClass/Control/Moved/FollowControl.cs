using System;
using UnityEngine;

namespace AbstractClass.Control.Moved
{
    [Serializable]
    public class FollowControl : AbstructControl
    {
        public FollowControl(Transform transformObject, Transform transformControl, float distance) : base(transformObject, transformControl, distance)
        {
        }
    }
}