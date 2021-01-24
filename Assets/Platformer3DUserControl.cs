using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformer3DUserControl : MonoBehaviour
{
    private PlatformerCharacter3D m_Character;
    private bool m_Jump;


    private void Awake()
    {
        m_Character = GetComponent<PlatformerCharacter3D>();
    }


    private void Update()
    {
        if (!m_Jump)
        {
            // Read the jump input in Update so button presses aren't missed.
            m_Jump = Input.GetButtonDown("Jump");
        }
    }


    private void FixedUpdate()
    {
        // Read the inputs.
        bool crouch = Input.GetKey(KeyCode.LeftControl);
        float h = Input.GetAxis("Horizontal");
        // Pass all parameters to the character control script.
        m_Character.Move(h, crouch, m_Jump);
        m_Jump = false;
    }
}
