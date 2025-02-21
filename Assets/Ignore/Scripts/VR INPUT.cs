
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using WindowsInput;
using static System.Runtime.CompilerServices.RuntimeHelpers;


public class VRINPUT : MonoBehaviour
{
    KeyboardSimulator bob = new KeyboardSimulator(new InputSimulator());
    int x = 0;
    int y = 0;
    private void Start()
    {
        // Create an instance of the InputSimulator
        bob.Mouse.LeftButtonClick();
    }
    //Swinging
    public void LeftMouseDown()
    {
        bob.Mouse.LeftButtonDown();
    }
    public void LeftMouseUp()
    {
        bob.Mouse.LeftButtonUp();
    }
    public void RightMouseDown()
    {
        bob.Mouse.RightButtonDown();
    }
    public void RightMouseUp()
    {
        bob.Mouse.RightButtonUp();
    }
    //Grappling
    public void PrimaryGrapple()
    {
        bob.KeyDown(VirtualKeyCode.SHIFT);
        bob.Mouse.LeftButtonDown();
    }
    public void ReleasePrimaryGrapple()
    {
        bob.KeyUp(VirtualKeyCode.SHIFT);
        bob.Mouse.LeftButtonUp();
    }
    public void SecondaryGrapple()
    {
        bob.KeyDown(VirtualKeyCode.SHIFT);
        bob.Mouse.RightButtonDown();
    }
    public void ReleaseSecondaryGrapple()
    {
        bob.KeyUp(VirtualKeyCode.SHIFT);
        bob.Mouse.LeftButtonUp();
    }

    //Movement
    public void MoveForward()
    {
        bob.KeyPress(VirtualKeyCode.VK_W);
    }
    public void MoveBackward()
    {
        bob.KeyPress(VirtualKeyCode.VK_S);
    }
    public void MoveLeft()
    {
        bob.KeyPress(VirtualKeyCode.VK_A);
    }
    public void MoveRight()
    {
        bob.KeyPress(VirtualKeyCode.VK_D);
    }
     public void Jump()
    {
        bob.KeyPress(VirtualKeyCode.SPACE);
    }

    //Mouse
    public void MouseUp()
    {
        bob.Mouse.MoveMouseTo(x, y-=1000);
    }
    public void MouseDown()
    {
        bob.Mouse.MoveMouseTo(x, y+=1000);
    }
    public void MouseLeft()
    {
        bob.Mouse.MoveMouseTo(x-=1000, y); 
    }
    public void MouseRight()
    {
        bob.Mouse.MoveMouseTo(x+=1000, y);
    }

}
 
 