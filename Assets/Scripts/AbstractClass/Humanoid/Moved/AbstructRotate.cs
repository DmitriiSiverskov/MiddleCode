using UnityEngine;

namespace AbstractClass.Humanoid.Moved
{
    public class AbstructRotate : AbstructMoved
    {
        public AbstructRotate(Transform transform, float speed, Vector3 vector3) : base(transform, speed, vector3) { }
        
        public override void Moved()
        {
            _transform.Rotate(_vector3,_speed * Time.deltaTime);
        }
    }
}