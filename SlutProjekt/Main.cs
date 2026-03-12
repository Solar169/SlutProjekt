using System.Numerics;
using Raylib_cs;


Raylib.InitWindow(1200, 800, "slutprojekt");
Raylib.SetTargetFPS(30);


// player
     Vector2 position = new Vector2(600f, 400f);

     Vector2 movementX = new Vector2(12.5f, 0);

     Vector2 movemntY = new Vector2(0, 12.5f);


// bullet

     List<string> bullets = [];
     Vector2 bullet_position = position;
     Vector2 bullet_movementy = new Vector2(0, 15);
     Vector2 bullet_movementx = new Vector2(15, 0);



while (!Raylib.WindowShouldClose())
{
 Raylib.BeginDrawing();

 Raylib.ClearBackground(Color.Black);

 if (Raylib.IsKeyDown(KeyboardKey.A))
    {
        position -= movementX;
    }

 if (Raylib.IsKeyDown(KeyboardKey.D))
    {
        position += movementX;
    }

 if (Raylib.IsKeyDown(KeyboardKey.W))
    {
        position -= movemntY;
    }

if (Raylib.IsKeyDown(KeyboardKey.S))
    {
        position += movemntY;
    }

if (Raylib.IsKeyPressed(KeyboardKey.Up))
    {
        
    }







 Raylib.DrawCircleV(position, 25, Color.Violet);

 Raylib.DrawCircleV(position, 5, Color.Red);

 Raylib.EndDrawing();
}






