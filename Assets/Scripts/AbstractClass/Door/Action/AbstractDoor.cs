using System;
using UnityEngine;

namespace AbstractClass.Door.Action
{
    [Serializable]
    public abstract class AbstractDoor
    {
       [SerializeField] private Transform _transformDoor;
       [SerializeField] private Transform _doorHandle;
       [SerializeField] private float _speed;
       [SerializeField] private float _openAngle;
       private const float _closingAngle = 0;
       [SerializeField] private bool _isOpen;
       [SerializeField] private bool _move;

       protected AbstractDoor(Transform transformDoor, Transform doorHandle, float speed, float openAngle, bool isOpen, bool move)
       {
           _transformDoor = transformDoor;
           _doorHandle = doorHandle;
           _speed = speed;
           _openAngle = openAngle;
           _isOpen = isOpen;
           _move = move;
       }
       
       public void Move()
        {
            if (_move)
            {
                if (!_isOpen)
                {
                    if (_transformDoor.rotation.y <= _openAngle)
                    {
                        _isOpen = true;
                        _move = false;
                    }
                    _transformDoor.Rotate(-Vector3.up * (_speed * Time.deltaTime));
                }
                else if(_isOpen)
                {
                    if (_transformDoor.rotation.y >= _closingAngle)
                    {
                        _isOpen = false;
                        _move = false;
                    }
                    _transformDoor.Rotate(Vector3.up * (_speed * Time.deltaTime));
                }
            }
        }

       public void OpenAndCloseDoor()
       {
           _move = true;
       }
    }
}