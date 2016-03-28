using UnityEngine;
using System.Collections;

public class Chessboard : MonoBehaviour {
	public Vector3 GetWorldPositionByCoordinates(int posX, int posY)
    {

        return new Vector3(-4 + posX, 1f, -3 + posY);
    }

    public int[] GetCoordinatesByWorldPosition(Vector3 worldPosition)
    {
        int x = (int)(worldPosition.x + 4.5f);
        int y = (int)(worldPosition.z + 3.5f);
        return new int[] { x, y };
    }
}
