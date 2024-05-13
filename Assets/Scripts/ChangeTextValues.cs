using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChangeTextValues : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    //[SerializeField] private Canvas canvas;
    [Space(50)]
    [SerializeField] private InputAction moveTextAction;
    [SerializeField] private float moveTextSpeed = 1f;
    [Space(50)]
    [SerializeField] private InputAction changeSizeTextAction;
    [SerializeField] private float changeSizeTextSpeed = 0.1f;
    //[Space(50)]
    //[SerializeField] private InputAction changeDistanceAction;
    //[SerializeField] private float changeDistanceSpeed = 1f;


    private bool triggerPressed = false;

    void Start()
    {
        moveTextAction.performed += MoveTextAction_performed;
        moveTextAction.canceled += MoveTextAction_canceled;
        moveTextAction.Enable();

        //changeSizeTextAction.performed += ChangeSizeTextAction_performed;
        //changeSizeTextAction.Enable();

        //changeDistanceAction.performed += ChangeDistanceAction_performed; ;
        //changeDistanceAction.Enable();
    }

    private void Update()
    {
        if (triggerPressed)
        {
            text.rectTransform.position += new Vector3(Time.deltaTime * moveTextSpeed * text.fontSize * -1, 0, 0);
        }
    }



    private void MoveTextAction_canceled(InputAction.CallbackContext obj)
    {
        triggerPressed = false;
    }

    private void MoveTextAction_performed(InputAction.CallbackContext obj)
    {
        triggerPressed = true;
    }

    //private void ChangeSizeTextAction_performed(InputAction.CallbackContext obj)
    //{
    //    Vector2 value = obj.ReadValue<Vector2>();

    //    if (Mathf.Abs(value.y) > 0.5f)
    //    {
    //        text.fontSize += (Time.deltaTime * value.y * changeSizeTextSpeed);
    //    }
    //}

    //private void ChangeDistanceAction_performed(InputAction.CallbackContext obj)
    //{
    //    Vector2 value = obj.ReadValue<Vector2>();

    //    if (Mathf.Abs(value.y) > 0.5f)
    //    {
    //        canvas.transform.position += new Vector3(0, 0, Time.deltaTime * value.y * changeDistanceSpeed);
    //    }
    //}
}
