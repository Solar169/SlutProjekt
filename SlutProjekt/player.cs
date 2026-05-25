using System.Drawing;
using System.Numerics;
using Player_namespace;
namespace Player_namespace
{
    



class Player
{
    // player
    public Vector2 position = new Vector2(600, 775);
    public Vector2 movementX = new Vector2(13, 0);
    public Vector2 movementY = new Vector2(0, 13);

    public int size = 25;

}


class Enemy
{
    public Vector2 position = new Vector2(0,0);
    public int size = 30;

    public Vector2 movementY = new Vector2(0, 5);

    public Vector2 movementX = new Vector2(5, 0);
}
}