using System;
using UnityEngine;

namespace AbstractClass.Control.Moved
{
    [Serializable]
    public class AbstructControl
    {
       [SerializeField] private Transform _transformObject;
       [SerializeField] private Transform _transformControl;
       [SerializeField] private float _distance;

        public AbstructControl(Transform transformObject, Transform transformControl, float distance)
        {
            _transformObject = transformObject;
            _transformControl = transformControl;
            _distance = distance;
        }

        public void Rotate()
        {
            var forward = _transformObject.forward;
            var transformObjectPosition = _transformObject.position + (forward * _distance);
            _transformControl.position = transformObjectPosition;
            _transformControl.rotation = Quaternion.LookRotation(forward);
        }
    }
}