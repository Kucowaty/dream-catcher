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
                newPosition = PositionRandomizer.RandomPointInBounds("DreamZone");
                timer = 0;
            }

            transform.position = Vector3.Lerp(transform.position, newPosition, speed );
        }

    }
}