using System;
using Data.MyRayCast;
using UnityEngine;

namespace AbstractClass.MyRayCast
{
    [Serializable]
    public class AbstractMyRayCast : MonoBehaviour
    {
        [SerializeField] private DataRayCast _dataRayCast;

        public DataRayCast DataRayCast => _dataRayCast;
    }
}