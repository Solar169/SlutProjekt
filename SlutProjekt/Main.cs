using System.Numerics;
using Raylib_cs;


Raylib.InitWindow(800, 600, "slutprojekt");
Raylib.SetTargetFPS(30);

     Vector2 position = new Vector2(350f, 200f);

     Vector2 movementX = new Vector2(10, 0);

     Vector2 movemntY = new Vector2(0, 10);


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

 Raylib.DrawCircleSector(position, 50, 0, -45, 100, Color.Violet);

 Raylib.DrawEllipse(100, 250, 50, 100, Color.Red);

 Raylib.EndDrawing();
}