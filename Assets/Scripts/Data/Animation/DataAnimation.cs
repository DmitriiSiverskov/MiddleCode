using System;
using AbstractClass.Animation;
using UnityEngine;

namespace Data.Animation
{
    [Serializable]
    public class DataAnimation
    {
        [SerializeField] private AnimationIdle _animationIdle;
        [SerializeField] private AnimationWalk _animationWalk;
        [SerializeField] private AnimationWalkBack _animationWalkBack;
        [SerializeField] private AnimationRotateLeft _animationLeftRotate;
        [SerializeField] private AnimationRotateRight _animationRightRotate;

        public AnimationIdle AnimationIdleIdle => _animationIdle;
        public AnimationWalk AnimationWalk => _animationWalk;
        public AnimationWalkBack AnimationWalkBack => _animationWalkBack;
        public AnimationRotateLeft AnimationLeftRotate => _animationLeftRotate;
        public AnimationRotateRight AnimationRightRotate => _animationRightRotate;

    }
}