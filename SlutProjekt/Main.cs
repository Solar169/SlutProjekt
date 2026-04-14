using System.Numerics;
using System.Runtime.Intrinsics.X86;
using Raylib_cs;
using Player_namespace;


Raylib.InitWindow(1200, 800, "slutprojekt");
Raylib.SetTargetFPS(30);


Player g1 = new Player();


while (!Raylib.WindowShouldClose())
{
 Raylib.BeginDrawing();

 Raylib.ClearBackground(Color.White);



// player movement
 if (Raylib.IsKeyDown(KeyboardKey.A))
    {
        g1.position -= g1.movementX;
    }

 if (Raylib.IsKeyDown(KeyboardKey.D))
    {
        g1.position += g1.movementX;
    }

  if (Raylib.IsKeyDown(KeyboardKey.W))
     {
         g1.position -= g1.movemntY;
     }

  if (Raylib.IsKeyDown(KeyboardKey.S))
     {
         g1.position += g1.movemntY;
    }

 Raylib.DrawCircleV(g1.position, 25, Color.Violet);




 
 Raylib.EndDrawing();
}