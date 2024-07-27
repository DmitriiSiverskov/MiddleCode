using System;
using AbstractClass.MyRayCast.SetRayCast;
using UnityEngine;

namespace Data.MyRayCast
{
    [Serializable]
    public class DataRayCast
    {
        [SerializeField] private HeadRayCast _headRayCast;

        public HeadRayCast HeadRayCast => _headRayCast;
    }
}