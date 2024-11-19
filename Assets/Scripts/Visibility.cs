using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Visibility : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The button for orange-airplane to disappear")]
    public InputAction toggleAction=new InputAction(type:InputActionType.Button);
    private Renderer objectRenderer;
    void OnEnable()
    {
        toggleAction.Enable();
        toggleAction.performed += OnToggleVisibility;
    }

    void OnDisable()
    {
        toggleAction.performed -= OnToggleVisibility;
        toggleAction.Disable();
    }

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        if (objectRenderer == null)
        {
            Debug.LogError("Renderer component is missing!");
        }
    }

    private void OnToggleVisibility(InputAction.CallbackContext context)
    {
        if (objectRenderer != null)
        {
            objectRenderer.enabled = !objectRenderer.enabled;
        }
    }
}
