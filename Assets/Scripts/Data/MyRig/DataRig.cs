using System;
using AbstractClass.MyRig.LimitRigWeight;
using UnityEngine;

namespace Data.MyRig
{
    [Serializable]
    public class DataRig
    {
        [SerializeField] private LimitRigHead _limitRigHead;

        public LimitRigHead LimitRigHead => _limitRigHead;
    }
}