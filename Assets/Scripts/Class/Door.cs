using AbstractClass.Door;

namespace Class
{
    public class Door : AbstractDoor
    {
        private void LateUpdate()
        {
            DataDoor.Door.Move();
        }
    }
}