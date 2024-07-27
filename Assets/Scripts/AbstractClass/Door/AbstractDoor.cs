using System;
using Data.Door;
using UnityEngine;

namespace AbstractClass.Door
{
    [Serializable]
    public abstract class AbstractDoor : MonoBehaviour
    {
        [SerializeField] private DataDoor _dataDoor;

        public DataDoor DataDoor => _dataDoor;
    }
}