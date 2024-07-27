using System;
using UnityEngine;

namespace AbstractClass.Door.Action
{
    [Serializable]
    public class Door : AbstractDoor
    {
        public Door(Transform transformDoor, Transform doorHandle, float speed, float openAngle, bool isOpen, bool move) : base(transformDoor, doorHandle, speed, openAngle, isOpen, move)
        {
        }
    }
}