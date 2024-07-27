using System;
using UnityEngine;

namespace AbstractClass.MyCamera.Moved
{
    [Serializable]
    public abstract class AbstractCamera
    {
        [SerializeField] private Transform _transformCamera;
        [SerializeField] private Transform _transformTarget;
        private Quaternion _quaternionObject;
        [SerializeField] private float _speedRotate;
        [SerializeField] private float _distance;
        [SerializeField] private float _minDegree;
        [SerializeField] private float _maxDegree;

        public AbstractCamera(Transform transformCamera,Transform transformTarget, Quaternion quaternionObjectCamera, float speedRotate, float minDegree, float maxDegree, float distance)
        {
            _transformCamera = transformCamera;
            _transformTarget = transformTarget;
            _quaternionObject = quaternionObjectCamera;
            _speedRotate = speedRotate;
            _minDegree = minDegree;
            _maxDegree = maxDegree;
            _distance = distance;

        }
        
        public void Rotate()
        {
            _quaternionObject.x -= Input.GetAxis("Mouse Y") * _speedRotate * Time.deltaTime;
            _quaternionObject.y += Input.GetAxis("Mouse X") * _speedRotate * Time.deltaTime;

            _quaternionObject.x = VerticalRestriction(_quaternionObject.x, _minDegree, _maxDegree);
            
            _transformCamera.rotation = Quaternion.Euler(_quaternionObject.x,_quaternionObject.y,_quaternionObject.z);
            OffsetCamera();
        }

        private float VerticalRestriction(float x, float min, float max) // Ограничение по вертикали
        {
            return Mathf.Clamp(x, min, max);
        }

        private void OffsetCamera()
        {
            var transformTargetPosition = _transformTarget.position;
            var transformCameraForward = transformTargetPosition - _transformCamera.forward * _distance;
            _transformCamera.position = transformCameraForward;
        }
    }
}