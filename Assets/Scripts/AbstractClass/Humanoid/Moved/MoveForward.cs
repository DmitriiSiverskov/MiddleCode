using System;
using UnityEngine;

namespace AbstractClass.Humanoid.Moved
{
    [Serializable]
    public class MoveForward : AbstructMoved
    {
        public MoveForward(Transform transform, float speed, Vector3 vector3) : base(transform, speed, vector3)
        {
        }
    }
}