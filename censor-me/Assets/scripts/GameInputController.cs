using UnityEngine;
using System.Collections;

/*
 * control  - 00
 * jumping  - 01
 * shooting - 10
 * both     - 11
 */

public class GameInputController : MonoBehaviour {
    enum Button {
        SHOOT,
        JUMP
    };

    private int control;

    public void Press(string button) {
        if (button == Button.JUMP.ToString()) {
            control += 1;
        } else if (button == Button.SHOOT.ToString()) {
            control += 2;
        }
    }

    public void Release(string button)
    {
        if (button == Button.JUMP.ToString()) {
            control -= 1;
        } else if (button == Button.SHOOT.ToString()) {
            control -= 2;
        }
    }

    public int Control() {
        return control;
    }

    public bool IsJumping() {
        return (control & 1) == 1;
    }

    public bool IsShooting() {
        return (control & 2) == 2;
    }
}
