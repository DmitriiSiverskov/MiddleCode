using Data.Animation;
using UnityEngine;

namespace AbstractClass.Humanoid
{
    
    public abstract class AbstructHumanoid : MonoBehaviour
    {
        [SerializeField] private Data.Humanoid.Data _data;
        [SerializeField] private DataAnimation _dataAnimation;

        public Data.Humanoid.Data Data => _data;
        public DataAnimation DataAnimation => _dataAnimation;
    }
}