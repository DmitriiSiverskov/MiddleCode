using System;
using UnityEngine;

namespace AbstractClass.MyRayCast.SetRayCast
{
    [Serializable]
    public class HeadRayCast : AbstractMyRayCast
    {
        protected HeadRayCast(Transform transformObject, Ray ray) : base(transformObject, ray) { }
        
        public virtual void FindObject()
        {
            CreateRayCast();
            if (Physics.Raycast(Ray, out var hit))
            {
                if(hit.transform.CompareTag("Door"))
                {
                    var component = hit.transform.GetComponent<Class.Door>();
                    if (Input.GetKey(KeyCode.E))
                    {
                        component.DataDoor.Door.OpenAndCloseDoor();
                    }
                }
            }
        }
    }
}