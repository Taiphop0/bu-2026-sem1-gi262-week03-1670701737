using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Solution
{

    public class Identity : MonoBehaviour
    {
        [Header("Identity")]
        public string Name;
        public int positionX;
        public int positionY;

        public OOPMapGenerator mapGenerator;

        public void PrintInfo()
        {
            Debug.Log("Name: {name}");
        }

        public virtual void Hit()
        {

        }
    }
}