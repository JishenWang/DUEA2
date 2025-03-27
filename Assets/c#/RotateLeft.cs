using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class RotateLeft : MonoBehaviour
{
    public Transform player;          // 要旋转的Player对象
    public float rotateAngle = 30f;  // 每次旋转的角度

    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(RotatePlayerLeft);
    }

    void RotatePlayerLeft()
    {
        if (player != null)
            player.Rotate(0f, -rotateAngle, 0f);
    }
}