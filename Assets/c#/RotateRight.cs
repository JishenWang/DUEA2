using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class RotateRight : MonoBehaviour
{
    public Transform player;         
    public float rotateAngle = 30f;  

    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(RotatePlayerRight);
    }

    void RotatePlayerRight()
    {
        if (player != null)
            player.Rotate(0f, rotateAngle, 0f);
    }
}
