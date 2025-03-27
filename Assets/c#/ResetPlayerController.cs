using UnityEngine;

public class ResetPlayerController : MonoBehaviour
{
    // �����ֶ���ק��ֵ
    [Header("��������")]
    public Transform playerTransform;

    // �Զ���¼�ĳ�ʼֵ
    private Vector3 initialPosition;
    private Vector3 initialScale;
    private Quaternion initialRotation;

    void Start()
    {
        if (playerTransform == null)
        {
            Debug.LogError("δ����Player��������ű���" + gameObject.name);
            return;
        }

        // �Զ���¼��ʼ״̬
        initialPosition = playerTransform.position;
        initialScale = playerTransform.localScale;
        initialRotation = playerTransform.rotation;

        Debug.Log("�Ѽ�¼��ʼ״̬��λ��=" + initialPosition);
    }

    // ������UI��ť���õķ���
    public void ExecuteReset()
    {
        if (playerTransform == null)
        {
            Debug.LogError("Player����ʧ��");
            return;
        }

        playerTransform.position = initialPosition;
        playerTransform.localScale = initialScale;
        playerTransform.rotation = initialRotation;

        Debug.Log("Player������", playerTransform);
    }
}