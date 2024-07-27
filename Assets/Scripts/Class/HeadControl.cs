using AbstractClass.Control;

namespace Class
{
    public class HeadControl : AbstractControl
    {
        private void LateUpdate()
        {
            DataControl.FollowControl.Rotate();
        }
    }
}