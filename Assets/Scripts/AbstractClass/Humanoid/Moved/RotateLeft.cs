using System;
using UnityEngine;

namespace AbstractClass.Humanoid.Moved
{
    [Serializable]
    public class RotateLeft : AbstructRotate
    {
        public RotateLeft(Transform transform, float speed, Vector3 vector3) : base(transform, speed, vector3)
        {
        }
    }
}