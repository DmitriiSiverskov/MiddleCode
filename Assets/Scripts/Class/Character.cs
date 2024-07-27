using AbstractClass.Humanoid;
using Enum;
using UnityEngine;

namespace Class
{
    public class Character : AbstructHumanoid
    {
        private void Update()
        {
            if (Input.GetKey(KeyCode.W))
            {
                Data.StateCharacter = StateCharacter.Walk;
                Data.MoveForward.Moved();
                DataAnimation.AnimationWalk.Action();
                if (Input.GetKey(KeyCode.W) & Input.GetKey(KeyCode.A))
                {
                    Data.RotateLeft.Moved();
                }
                else if (Input.GetKey(KeyCode.W) & Input.GetKey(KeyCode.D))
                {
                    Data.RotateRight.Moved();
                }
            }
            
            else if (Input.GetKey(KeyCode.S))
            {
                Data.StateCharacter = StateCharacter.WalkBack;
                Data.MoveBack.Moved();
                DataAnimation.AnimationWalkBack.Action();
            }
            
            else if (Input.GetKey(KeyCode.A))
            {
                Data.StateCharacter = StateCharacter.RotateLeft;
                Data.RotateLeft.Moved();
                DataAnimation.AnimationLeftRotate.Action();
                
            }
            
            else if (Input.GetKey(KeyCode.D))
            {
                Data.StateCharacter = StateCharacter.RotateRight;
                Data.RotateRight.Moved();
                DataAnimation.AnimationRightRotate.Action();
            }
            else
            {
                Data.StateCharacter = StateCharacter.Idle;
                DataAnimation.AnimationIdleIdle.Action();
            }
            
        }
    }
}