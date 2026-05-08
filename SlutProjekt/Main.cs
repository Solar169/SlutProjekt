using Raylib_cs;
using Player_namespace;
using Attack_namespace;

Raylib.InitWindow(1200, 800, "slutprojekt");
Raylib.SetTargetFPS(30);


Player p1 = new Player();

Enemy e1 = new Enemy();

bool dead = false;

while (!Raylib.WindowShouldClose())
{
// player movement
 if (Raylib.IsKeyDown(KeyboardKey.A))
    {
        p1.position -= p1.movementX;
    }

 if (Raylib.IsKeyDown(KeyboardKey.D))
    {
        p1.position += p1.movementX;
    }

 if (Raylib.IsKeyDown(KeyboardKey.W))
     {
         p1.position -= p1.movementY;
     }

 if (Raylib.IsKeyDown(KeyboardKey.S))
     {
         p1.position += p1.movementY;
    }

//  player attack
  if (Raylib.IsKeyPressed(KeyboardKey.Up))
    {
        Attack a1 = new Attack();

        a1.startposition = p1.position;

        Raylib.DrawCircleSector(a1.startposition, a1.size, -45, -135, 100, Color.Violet);
    }

  if (Raylib.IsKeyPressed(KeyboardKey.Down))
    {
        Attack a1 = new Attack();

        a1.startposition = p1.position;

        Raylib.DrawCircleSector(a1.startposition, a1.size, 45, 135, 100, Color.Violet);
    }

  if (Raylib.IsKeyPressed(KeyboardKey.Right))
    {
        Attack a1 = new Attack();

       a1.startposition = p1.position;

        Raylib.DrawCircleSector (a1.startposition, a1.size, 45, -45, 100, Color.Violet);
    }

  if (Raylib.IsKeyPressed(KeyboardKey.Left))
    {
        Attack a1 = new Attack();

        a1.startposition = p1.position;

        Raylib.DrawCircleSector(a1.startposition, a1.size, -135, -225, 100, Color.Violet);
    }

    // enemy movement towards player
    if (e1.position.X > p1.position.X)
    {
        e1.position -= e1.movementX;
    }
    
    if (e1.position.X < p1.position.X)
    {
        e1.position += e1.movementX;
    }
    
    if (e1.position.Y > p1.position.Y)
    {
        e1.position -= e1.movementY;
    }
    
    if (e1.position.Y < p1.position.Y)
    {
        e1.position += e1.movementY;
    }

    bool areOverlapping = Raylib.CheckCollisionCircles(p1.position, p1.size, e1.position, e1.size);
    if (areOverlapping == true)
    {
        dead = true;
    }

    if (dead == true)
    {
        break;
    }

    




 Raylib.BeginDrawing();

 Raylib.ClearBackground(Color.White);

//  player
 Raylib.DrawCircleV(p1.position, p1.size, Color.Green);
// enemy
 Raylib.DrawCircleV(e1.position, e1.size, Color.Red);

 
 Raylib.EndDrawing();
}