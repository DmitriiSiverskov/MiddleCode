using Data.MyRig;
using UnityEngine;

namespace AbstractClass.MyRig
{
    
    public abstract class AbstractRig : MonoBehaviour
    {
        [SerializeField] private DataRig _dataRig;

        public DataRig DataRig => _dataRig;
    }
}