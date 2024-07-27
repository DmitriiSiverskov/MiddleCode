using System;
using UnityEngine;

namespace AbstractClass.Animation
{
    [Serializable]
    public class AnimationRotateRight : AbstractAnimation
    {
        public AnimationRotateRight(Animator animator, string nameAnimation) : base(animator, nameAnimation)
        {
        }
    }
}