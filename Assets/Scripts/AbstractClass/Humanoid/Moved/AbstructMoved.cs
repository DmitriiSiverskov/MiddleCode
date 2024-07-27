using System;
using UnityEngine;

namespace AbstractClass.Humanoid.Moved
{
    [Serializable]
    public abstract class AbstructMoved
    {
        [SerializeField] protected Transform _transform;
        [SerializeField] protected float _speed;
        [SerializeField] protected Vector3 _vector3;

        //public AbstructMoved() { }

        public AbstructMoved(Transform transform, float speed)
        {
            _transform = transform;
            _speed = speed;
        }
        public AbstructMoved(Transform transform, float speed, Vector3 vector3) : this(transform, speed)
        {
            _vector3 = vector3;
        }
        public virtual void Moved()
        {
            Vector3 direction = _transform.forward * _vector3.z + _transform.right * _vector3.x + _transform.up * _vector3.y;
            var transformPosition = _transform.position + direction * _speed * Time.deltaTime;
            _transform.position = transformPosition;
        }
    }
}