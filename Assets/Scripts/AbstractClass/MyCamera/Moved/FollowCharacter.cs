using System;
using UnityEngine;

namespace AbstractClass.MyCamera.Moved
{
    [Serializable]
    public class FollowCharacter : AbstractCamera
    {
        public FollowCharacter(Transform transformCamera, Transform transformTarget, Quaternion quaternionObjectCamera, float speedRotate, float minDegree, float maxDegree, float distance) : base(transformCamera, transformTarget, quaternionObjectCamera, speedRotate, minDegree, maxDegree, distance)
        {
        }
    }
}