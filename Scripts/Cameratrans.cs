using Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Camera
{
    public class Cameratrans : MonoBehaviour
    {
        public GameManager GameManager;

        private void Start()
        {
        }

        // Update is called once per frame
        private void Update()
        {
            var character = GameManager.Character.transform;
            transform.position = new Vector3(character.position.x, character.position.y, -10);
        }
    }
}