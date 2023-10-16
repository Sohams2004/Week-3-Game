using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Week_3;

namespace Week_3
{
    public class Jump : MonoBehaviour
    {
        [SerializeField] private bool firsClick;
        [SerializeField] private bool secondClick;

        private const float DoubleclickTime = 0.5f;
        public float lastClickTime;

        [SerializeField] private Movement movement;

        private void Update()
        {
            if (Input.GetMouseButtonUp(0))
            {
                float lastClick = Time.time - lastClickTime;

                if (lastClick <= DoubleclickTime)
                {
                    Debug.Log("Double click");
                    movement.Jump();
                }

                else
                {
                    Debug.Log("single click");
                }
                lastClickTime = Time.time;
            }
        }
    }
}

