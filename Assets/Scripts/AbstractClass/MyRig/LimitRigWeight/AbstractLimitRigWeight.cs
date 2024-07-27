using System;
using Class;
using UnityEngine;
using UnityEngine.Animations.Rigging;

namespace AbstractClass.MyRig.LimitRigWeight
{
    [Serializable]
    public class AbstractLimitRigWeight
    {
        [SerializeField] private Rig _rig;
        [SerializeField] private Transform _transformControl;
        [SerializeField] private Character _character;
        [SerializeField] private float _speed;
        [SerializeField] private float _limitRotateLeft;
        [SerializeField] private float _limitRotateRight;
        [SerializeField] private float _comparison;
        [SerializeField] private float _tolerance;

        public Character Character => _character;
        public Rig Rig => _rig;

        public AbstractLimitRigWeight(Rig rig, Transform transformControl, Character character, float speed, float limitRotateLeft, float limitRotateRight, float comparison, float tolerance)
        {
            _rig = rig;
            _transformControl = transformControl;
            _character = character;
            _speed = speed;
            _limitRotateLeft = limitRotateLeft;
            _limitRotateRight = limitRotateRight;
            _comparison = comparison;
            _tolerance = tolerance;
        }
        public virtual void LimitRotate()
        {
            if (_transformControl.localRotation.y < 0 & _transformControl.localRotation.y < _limitRotateLeft || _transformControl.localRotation.y > 0 & _transformControl.localRotation.y > _limitRotateRight)
            {
                if (_rig.weight <= 0)
                {
                    return;
                }
                _rig.weight -= Time.deltaTime * _speed;
            }
            else
            {
                if (Math.Abs(_rig.weight - _comparison) > _tolerance)
                {
                    _rig.weight += Time.deltaTime * _speed;
                }
            }
        }
    }
}