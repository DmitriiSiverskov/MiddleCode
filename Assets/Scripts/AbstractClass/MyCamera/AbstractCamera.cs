using System;
using Data.MyCamera;
using UnityEngine;

namespace AbstractClass.MyCamera
{
    [Serializable]
    public class AbstractCamera : MonoBehaviour
    {
        [SerializeField] private DataCamera _dataCamera;

        public DataCamera DataCamera => _dataCamera;
    }
}