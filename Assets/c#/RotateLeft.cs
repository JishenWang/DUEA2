using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class RotateLeft : MonoBehaviour
{
    public Transform player;          // Ҫ��ת��Player����
    public float rotateAngle = 30f;  // ÿ����ת�ĽǶ�

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