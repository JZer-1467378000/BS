using Character;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerInputs
{
    public class PlayerInput : MonoBehaviour
    {
        private PlayerCharacter m_Character = null;

        public void SetCharacter(PlayerCharacter character)
        {
            m_Character = character;
        }

        private void Update()
        {
            var x = Input.GetAxis("Horizontal");
            var y = Input.GetAxis("Vertical");
            var velocity = new Vector2(x, y);
            if (m_Character)
            {
                m_Character.Move(velocity);
                if (Input.GetKeyDown(KeyCode.F))
                {
                    m_Character.Interact();
                }
            }
        }
    }
}