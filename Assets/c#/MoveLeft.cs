using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class MoveLeft : MonoBehaviour
{
    public Transform player;          // Ҫ�ƶ���Player����
    public float moveDistance = 1f;   // ÿ���ƶ��ľ���

    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(MovePlayerLeft);
    }

    void MovePlayerLeft()
    {
        if (player != null)
            player.Translate(Vector3.left * moveDistance);
    }
}
