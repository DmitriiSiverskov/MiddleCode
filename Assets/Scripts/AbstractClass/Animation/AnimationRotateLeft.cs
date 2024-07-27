using System;
using UnityEngine;

namespace AbstractClass.Animation
{
    [Serializable]
    public class AnimationRotateLeft : AbstractAnimation
    {
        public AnimationRotateLeft(Animator animator, string nameAnimation) : base(animator, nameAnimation)
        {
        }
    }
}