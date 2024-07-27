using System;
using Class;
using Enum;
using UnityEngine;
using UnityEngine.Animations.Rigging;

namespace AbstractClass.MyRig.LimitRigWeight
{
    [Serializable]
    public class LimitRigHead : AbstractLimitRigWeight
    {
        public LimitRigHead(Rig rig, Transform transformControl, Character character, float speed, float limitRotateLeft, float limitRotateRight, float comparison, float tolerance) : base(rig, transformControl, character, speed, limitRotateLeft, limitRotateRight, comparison, tolerance)
        {
        }
        public override void LimitRotate()
         {
           if (Character.Data.StateCharacter != StateCharacter.WalkBack)
           {
               base.LimitRotate();
           }
           else
           {
               if (Rig.weight <= 0)
               {
                   return;
               }
               Rig.weight -= Time.deltaTime;
           }
         }
    }
}