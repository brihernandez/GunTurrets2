using UnityEngine;

namespace GT2.Demo
{
    public class RockingBoat : MonoBehaviour
    {
        public float strength = 1f;
        public float speed = 1f;

        private Vector3 eulers = Vector3.zero;
        private float offset = 0f;

        private void Awake()
        {
            offset = Random.Range(0f, 1000f);
        }

        private void Update()
        {
            var time = Time.time;
            eulers.x = Mathf.Sin(time * speed + offset) * strength;
            eulers.z = Mathf.Cos(time * speed * .8f + 11f + offset) * strength;

            transform.localEulerAngles = eulers;
        }
    }
}