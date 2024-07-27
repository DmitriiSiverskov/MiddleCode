using AbstractClass.MyCamera;


namespace Class
{
    public class MyCamera : AbstractCamera
    {
        private void LateUpdate()
        {
            DataCamera.FollowCharacter.Rotate();
        }
    }
}