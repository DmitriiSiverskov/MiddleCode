using System;
using UnityEngine;

namespace AbstractClass.Animation
{
    [Serializable]
    public class AnimationWalkBack : AbstractAnimation
    {
        public AnimationWalkBack(Animator animator, string nameAnimation) : base(animator, nameAnimation)
        {
        }
    }
}