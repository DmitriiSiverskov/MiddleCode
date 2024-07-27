using System;
using AbstractClass.Humanoid.Moved;
using Enum;
using UnityEngine;

namespace Data.Humanoid
{
    [Serializable]
    public class Data
    {
        [SerializeField] public StateCharacter StateCharacter;
        [SerializeField] private MoveForward _moveForward;
        [SerializeField] private MoveBack _moveBack;
        [SerializeField] private RotateLeft rotateLeft;
        [SerializeField] private RotateRight rotateRight;
        public MoveForward MoveForward => _moveForward;
        public MoveBack MoveBack => _moveBack;
        public RotateLeft RotateLeft => rotateLeft;
        public RotateRight RotateRight => rotateRight;
    }
}