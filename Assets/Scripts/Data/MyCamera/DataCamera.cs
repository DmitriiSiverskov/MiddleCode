using System;
using AbstractClass.MyCamera.Moved;
using UnityEngine;

namespace Data.MyCamera
{
    [Serializable]
    public class DataCamera
    {
        [SerializeField] private FollowCharacter _followCharacter;

        public FollowCharacter FollowCharacter => _followCharacter;
    }
}