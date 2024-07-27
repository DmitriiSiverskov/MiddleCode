using System;
using Data.Control;
using UnityEngine;

namespace AbstractClass.Control
{
    [Serializable]
    public abstract class AbstractControl : MonoBehaviour
    {
        [SerializeField] private DataControl _dataControl;

        public DataControl DataControl => _dataControl;
    }
}