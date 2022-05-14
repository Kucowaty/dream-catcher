using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    
    public class Dream : MonoBehaviour
    {
        public int numberOfDreams = 10;
        public GameObject prefab;
        void Start()
        {
            SpawnDreams(numberOfDreams);
        }

        private void SpawnDreams(int i)
        {
            while (i > 0)
            {
                SpawnDream();
                i--;
            }
        }


        private GameObject SpawnDream()
        {
            return Instantiate(prefab, PositionRandomizer.RandomPointInBounds("DreamZone"), Quaternion.identity);
        }
    }
}