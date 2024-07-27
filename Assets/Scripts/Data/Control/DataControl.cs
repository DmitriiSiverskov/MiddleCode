using System;
using AbstractClass.Control.Moved;
using UnityEngine;

namespace Data.Control
{
    [Serializable]
    public class DataControl
    {
        [SerializeField] private FollowControl _followControl;

        public FollowControl FollowControl => _followControl;
    }
}