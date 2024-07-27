using System;
using UnityEngine;

namespace AbstractClass.MyRayCast.SetRayCast
{
    [Serializable]
    public abstract class AbstractMyRayCast
    {
        [SerializeField] private Transform _transformObject;
        private Ray _ray;

        public Ray Ray => _ray;
        public AbstractMyRayCast(Transform transformObject, Ray ray)
        {
            _transformObject = transformObject;
            _ray = ray;
        }

        protected void CreateRayCast()
        {
            var position = _transformObject.position;
            var forward = _transformObject.TransformDirection(Vector3.forward);
            _ray = new Ray(position, forward);
            Debug.DrawRay(position,forward * 100, Color.blue);
        }
    }
}