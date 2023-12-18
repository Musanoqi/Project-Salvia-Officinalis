using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TransformationTranslate : MonoBehaviour
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right,
        Forward,
        Back
    }

    [Header("Main Settings")]
    public Direction moveDirection; // Enum untuk memilih arah pergerakan
    public float moveSpeed = 1.0f; // Kecepatan pergerakan
    public bool updatePosition;

    [Header("Event Settings")]
    public UnityEvent startEvents;
    public UnityEvent updateEvents;

    // Start is called before the first frame update
    void Start()
    {
        startEvents?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        if (updatePosition)
        {
            MoveInDirection();
        }

        updateEvents?.Invoke();
    }

    private void MoveInDirection()
    {
        Vector3 moveVector = Vector3.zero;

        switch (moveDirection)
        {
            case Direction.Up:
                moveVector = Vector3.up;
                break;
            case Direction.Down:
                moveVector = Vector3.down;
                break;
            case Direction.Left:
                moveVector = Vector3.left;
                break;
            case Direction.Right:
                moveVector = Vector3.right;
                break;
            case Direction.Forward:
                moveVector = Vector3.forward;
                break;
            case Direction.Back:
                moveVector = Vector3.back;
                break;
        }

        // Menggunakan Translate untuk memindahkan objek sesuai dengan arah dan kecepatan yang dipilih
        transform.Translate(moveVector * moveSpeed * Time.deltaTime);
    }
}

