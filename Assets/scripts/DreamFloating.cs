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
                newPosition = RandomPointInBounds();
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

        public static Vector3 RandomPointInBounds() {
            GameObject gameObject = GameObject.Find("DreamZone");
            Bounds bounds = gameObject.GetComponent<Collider>().bounds;
            return new Vector3(
                Random.Range(bounds.min.x, bounds.max.x),
                Random.Range(bounds.min.y, bounds.max.y),
                Random.Range(bounds.min.z, bounds.max.z)
            );
        }

    }
}