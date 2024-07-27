using System;
using UnityEngine;

namespace AbstractClass.Animation
{
    [Serializable]
    public class AbstractAnimation
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private string _nameAnimation;

        public AbstractAnimation(Animator animator, string nameAnimation)
        {
            _animator = animator;
            _nameAnimation = nameAnimation;
        }

        public virtual void Action()
        {
            _animator.SetTrigger(_nameAnimation);
        }
    }
}