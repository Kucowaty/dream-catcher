using UnityEngine;

namespace DefaultNamespace
{
    public class PositionRandomizer
    {
        public static Vector3 RandomPointInBounds(string dreamzone) {
            GameObject gameObject = GameObject.Find(dreamzone);
            Bounds bounds = gameObject.GetComponent<Collider>().bounds;
            return new Vector3(
                Random.Range(bounds.min.x, bounds.max.x),
                Random.Range(bounds.min.y, bounds.max.y),
                Random.Range(bounds.min.z, bounds.max.z)
            );
        }

    }
}