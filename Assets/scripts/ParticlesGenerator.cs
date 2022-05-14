using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    public class ParticlesGenerator : MonoBehaviour
    {
        public int numberOfParticles = 1000;
        public GameObject prefab;
        void Start()
        {
            SpawnDreams(numberOfParticles);
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