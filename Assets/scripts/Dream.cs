using System;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

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
            return Instantiate(prefab, RandomPosition(), Quaternion.identity);
        }

        private Vector3 RandomPosition()
        {
            float x = Random.Range(-2.0F, 2.0F);
            float y = 2;
            float z = Random.Range(-2.0F, 2.0F);
            return new Vector3(x, y, z);
        }

    }
}