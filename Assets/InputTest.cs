using UnityEngine;
using UnityEngine.InputSystem;

public class InputTest : MonoBehaviour
{
  public PlayerInput PlayerInput;

  public void Awake()
  {
    PlayerInput.onActionTriggered += PlayerInputOnonActionTriggered;

    PlayerInput.actions["Cancel"].performed += CancelUsed;
  }

  private void PlayerInputOnonActionTriggered(InputAction.CallbackContext context)
  {
    switch (context.action.name)
    {
      case "Submit":
        if (context.performed) Debug.Log("Submit pressed!");
        break;
    }
  }

  public void OnDisable()
  {
    PlayerInput.actions["Cancel"].performed -= CancelUsed;
    PlayerInput.onActionTriggered -= PlayerInputOnonActionTriggered;
  }

  private void CancelUsed(InputAction.CallbackContext obj)
  {
    Debug.Log("Cancel pressed!");
  }
}