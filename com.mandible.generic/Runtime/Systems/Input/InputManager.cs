using UnityEngine;

public class InputManager : MonoBehaviour
{
    public enum InputMode { Gameplay, UI }

    [Header("Cursor")]
    [SerializeField] InputMode inputMode;

    //Cursor
    void Start()
    {
        SetMode(inputMode);
    }

    public void SetMode(InputMode mode)
    {
        switch (mode)
        {
            case InputMode.Gameplay:
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                break;
            case InputMode.UI:
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                break;
        }
    }
}
