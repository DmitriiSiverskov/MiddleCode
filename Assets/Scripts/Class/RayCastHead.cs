using AbstractClass.MyRayCast;
using UnityEngine;

namespace Class
{
    public class RayCastHead : AbstractMyRayCast
    {
        private float _timer = 0.1f;
        private void Update()
        {
            if (_timer > 0)
            {
                _timer -= Time.deltaTime;
                return;
            }
            DataRayCast.HeadRayCast.FindObject();
            _timer = 0.1f;
        }
    }
}