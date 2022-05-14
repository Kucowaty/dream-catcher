using UnityEngine;

namespace DefaultNamespace
{
    public class DreamFloating : MonoBehaviour
    {
        public float timeToMove = 2F;
        private float timer = 0;
        private float speed = 0.005F;
        private Vector3 newPosition;

        private void Update()
        {
            timer += Time.deltaTime;
            if (timer > timeToMove)
            {
                newPosition = RandomPosition();
                timer = 0;
            }

            transform.position = Vector3.Lerp(transform.position, newPosition, speed );
        }
        
        private Vector3 RandomPosition()
        {
            float x = Random.Range(-3F, 3.0F);
            float y = Random.Range(0.0F, 3.0F);
            float z = Random.Range(-3F, 3F);
            return new Vector3(x, y, z);
        }


    }
}