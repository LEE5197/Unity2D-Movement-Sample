using UnityEngine;

public class Collision : MonoBehaviour
{
    [Header("Layers")]
    public LayerMask groundLayer;

    [Space]

    public bool isGround;
    public bool isLeftWall;
    public bool isRightWall;
    public bool dashReady;

    [Space]

    [Header("Collision")]
    public Vector2 bottomOffset = new Vector2(0f, -0.5f);
    public Vector2 groundBoxSize = new Vector2(0.5f, 0.2f); // �ڽ��� ����, ���� ũ��

    public Vector2 leftOffset = new Vector2(-0.5f, 0f);
    public Vector2 leftBoxSize = new Vector2(0.2f, 0.5f); // �ڽ��� ����, ���� ũ��

    public Vector2 rightOffset = new Vector2(0.5f, 0f);
    public Vector2 rightBoxSize = new Vector2(0.2f, 0.5f); // �ڽ��� ����, ���� ũ��


    void Update()
    {
        // Physics2D.OverlapBox�� ����Ͽ� isGround ���� ������Ʈ
        isGround = Physics2D.OverlapBox((Vector2)transform.position + bottomOffset, groundBoxSize, 0f, groundLayer);
        isLeftWall = Physics2D.OverlapBox((Vector2)transform.position + leftOffset, leftBoxSize, 0f, groundLayer);
        isRightWall = Physics2D.OverlapBox((Vector2)transform.position + rightOffset, rightBoxSize, 0f, groundLayer);
        if (isGround||isLeftWall||isRightWall) dashReady = true;
    }

    // ���� ���Ǹ� ���� �浹 ���� ������ �ð������� ǥ��
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube((Vector2)transform.position + bottomOffset, groundBoxSize);
        Gizmos.DrawWireCube((Vector2)transform.position + leftOffset, leftBoxSize);
        Gizmos.DrawWireCube((Vector2)transform.position + rightOffset, rightBoxSize);
    }
}