using System;
using UnityEngine;

namespace AbstractClass.Humanoid.Moved
{
    [Serializable]
    public class RotateRight : AbstructRotate
    {
        public RotateRight(Transform transform, float speed, Vector3 vector3) : base(transform, speed, vector3)
        {
        }
    }
}