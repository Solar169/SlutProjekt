using Raylib_cs;
using Player_namespace;
using Attack_namespace;

Raylib.InitWindow(1200, 800, "slutprojekt");
Raylib.SetTargetFPS(30);


Player p1 = new Player();


while (!Raylib.WindowShouldClose())
{
// player movement
 if (Raylib.IsKeyDown(KeyboardKey.A))
    {
        p1.position -= p1.movementX;
    }

 else if (Raylib.IsKeyDown(KeyboardKey.D))
    {
        p1.position += p1.movementX;
    }

  else if (Raylib.IsKeyDown(KeyboardKey.W))
     {
         p1.position -= p1.movemntY;
     }

  else if (Raylib.IsKeyDown(KeyboardKey.S))
     {
         p1.position += p1.movemntY;
    }


  if (Raylib.IsKeyPressed(KeyboardKey.Up))
    {
        Attack u1 = new Attack();

        u1.startposition = p1.position;

        Raylib.DrawCircleSector(u1.startposition, 60, -45, -135, 100, Color.Violet);
    }

  if (Raylib.IsKeyPressed(KeyboardKey.Down))
    {
        Attack d1 = new Attack();

        d1.startposition = p1.position;

        Raylib.DrawCircleSector(d1.startposition, 60, 45, 135, 100, Color.Violet);
    }

  if (Raylib.IsKeyPressed(KeyboardKey.Right))
    {
        Attack r1 = new Attack();

        r1.startposition = p1.position;

        Raylib.DrawCircleSector(r1.startposition, 60, 45, -45, 100, Color.Violet);
    }

  if (Raylib.IsKeyPressed(KeyboardKey.Left))
    {
        Attack l1 = new Attack();

        l1.startposition = p1.position;

        Raylib.DrawCircleSector(l1.startposition, 60, -135, -225, 100, Color.Violet);
    }


 Raylib.BeginDrawing();

 Raylib.ClearBackground(Color.White);

 
 
 
 
 
 
 Raylib.DrawCircleV(p1.position, 25, Color.Green);



 
 Raylib.EndDrawing();
}