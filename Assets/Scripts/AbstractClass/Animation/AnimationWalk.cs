using System;
using UnityEngine;

namespace AbstractClass.Animation
{
    [Serializable]
    public class AnimationWalk : AbstractAnimation
    {
        public AnimationWalk(Animator animator, string nameAnimation) : base(animator, nameAnimation)
        {
        }
    }
}