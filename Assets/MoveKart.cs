using UnityEngine;
using UnityEngine.InputSystem;

public class MoveKart : MonoBehaviour
{
    KartControls controls;

    LogicManagement logic;
    public float moveStep = 0.2f;
    public float minY = -2.5f;
    public float maxY = 4f;

    void Awake()
    {
        controls = new KartControls();
        controls.Enable();
    }

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagement>();
    }
    void Update()
    {
        Vector3 newPosition = transform.position;

        // Fixed condition with proper grouping
        if ((Keyboard.current.aKey.IsPressed() && controls.player.Up.IsPressed()) && logic.isHealthZero == false)
        {
            newPosition += Vector3.up * moveStep;
        }
        // Same fix for the Down movement
        else if ((Keyboard.current.lKey.IsPressed() && controls.player.Down.IsPressed()) && logic.isHealthZero == false)
        {
            newPosition += Vector3.down * moveStep;
        }

        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);
        transform.position = newPosition;
    }

    void OnDisable()
    {
        controls.Disable();
    }
}
