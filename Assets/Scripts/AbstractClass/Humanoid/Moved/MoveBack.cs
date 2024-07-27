using System;
using UnityEngine;

namespace AbstractClass.Humanoid.Moved
{
    [Serializable]
    public class MoveBack : AbstructMoved
    {
        public MoveBack(Transform transform, float speed, Vector3 vector3) : base(transform, speed, vector3)
        {
        }
    }
}