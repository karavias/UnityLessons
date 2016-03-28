using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Chessman : MonoBehaviour
{

    public ChessmanType chessColor = ChessmanType.WHITE;
    public int x;
    public int y;
    public ChessCharacter character = ChessCharacter.SOLDIER;
    public Chessboard board;

    public LayerMask acceptMask;

    public bool alive = true;

    //tropos 1 vima 1
    static List<Chessman> chessmen = new List<Chessman>();

    // Use this for initialization
    void Start()
    {
        transform.position = board.GetWorldPositionByCoordinates(x, y);

        //tropos1 vima 2
        chessmen.Add(this);
        
    }


    void OnMouseDown()
    {
        //Debug.Log("pioni clicked");
    }

    void OnMouseDrag()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 100.0f, acceptMask))
        {
            transform.position = hit.point;
        }
    }

    void OnMouseUp()
    {

        int tempX = board.GetCoordinatesByWorldPosition(transform.position)[0];
        int tempY = board.GetCoordinatesByWorldPosition(transform.position)[1];
        if (CanGoToPosition(tempX, tempY))
        {
            x = tempX;
            y = tempY;

            EatInPosition();

        }
        transform.position = board.GetWorldPositionByCoordinates(x, y);
    }

    void EatInPosition()
    {
        for (int index = 0; index < chessmen.Count; index++)
        {
            if (chessmen[index].x == x && chessmen[index].y == y
                && chessmen[index].chessColor != chessColor)
            {
                chessmen[index].Die();
            }
        }
    }

    public void Die()
    {
        alive = false;
        transform.position = new Vector3(7.5f, 0.5f, 4f);
    }


    bool CanGoToPosition(int newX, int newY)
    {
        if (character == ChessCharacter.SOLDIER)
        {
            if (chessColor == ChessmanType.BLACK)
            {
                return (newY == y + 1 && newX == x);
            }
            else
            {
                return (newY == y - 1 && newX == x);
            }
        }
        else if (character == ChessCharacter.CASTLE)
        {
            return (newY == y || newX == x) ;
        }
        else if (character == ChessCharacter.KING)
        {
            return ((newX == x || newX == x + 1 || newX == x - 1) && (newY == y || newY == y + 1 || newY == y - 1)) ;
        }
        else if (character == ChessCharacter.QUEEN)
        {
            return (newX == x || newY == y || Mathf.Abs(newX - x) == Mathf.Abs(newY - y));
        }
        else if (character == ChessCharacter.CRAZY)
        {
            return (Mathf.Abs(newX - x) == Mathf.Abs(newY - y));
        }
        else if (character == ChessCharacter.HORSE)
        {
            return (Mathf.Abs(newX - x) == 1 && Mathf.Abs(newY - y) == 2) || (Mathf.Abs(newX - x) == 2 && Mathf.Abs(newY - y) == 1);
        }
        return false;
    }
}

public enum ChessmanType
{
    WHITE,
    BLACK
}

public enum ChessCharacter
{
    SOLDIER,
    CASTLE,
    HORSE,
    CRAZY,
    KING,
    QUEEN
}