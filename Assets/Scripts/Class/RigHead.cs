using AbstractClass.MyRig;

namespace Class
{
    public class RigHead : AbstractRig
    {
        private void Update()
        {
            DataRig.LimitRigHead.LimitRotate();
        }
    }
}