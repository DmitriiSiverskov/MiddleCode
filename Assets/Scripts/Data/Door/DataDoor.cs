using System;
using UnityEngine;

namespace Data.Door
{
    [Serializable]
    public class DataDoor
    {
        [SerializeField] private AbstractClass.Door.Action.Door _door;

        public AbstractClass.Door.Action.Door Door => _door;
    }
}