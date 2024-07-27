using System;
using UnityEngine;

namespace AbstractClass.Animation
{
    [Serializable]
    public class AnimationIdle : AbstractAnimation
    {
        public AnimationIdle(Animator animator, string nameAnimation) : base(animator, nameAnimation)
        {
        }
    }
}