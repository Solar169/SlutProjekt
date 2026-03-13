using System.Numerics;
using Raylib_cs;


Raylib.InitWindow(1200, 800, "slutprojekt");
Raylib.SetTargetFPS(30);



// player
     Vector2 position = new Vector2(600f, 400f);
     Vector2 movementX = new Vector2(12.5f, 0f);
     Vector2 movemntY = new Vector2(0f, 12.5f);




while (!Raylib.WindowShouldClose())
{
 Raylib.BeginDrawing();

 Raylib.ClearBackground(Color.Black);



// player movement
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





 Raylib.DrawCircleV(position, 25, Color.Violet);




    



 Raylib.EndDrawing();
}




// barrier
//      Rectangle barrier = new Rectangle(15f, -20, 1200, 20);
// bullet
//      List<string> bullets = [];
//      Vector2 bullet_position = position;
//      Vector2 bullet_movementy = new Vector2(0f, 15f);
//      Vector2 bullet_movementx = new Vector2(15f, 0f);
//      int bullet_number=0;

// bullet spawn
// if (Raylib.IsKeyPressed(KeyboardKey.Up))
//     {
//         bullets.Add($"Bullet{bullet_number}");
//         bullet_number++;
//     }


// for (int i = 0; i < bullets.Count; i++)
// { 
//      Raylib.DrawCircleV(bullet_position -= bullet_movementy, 5, Color.Red);
// }
 
// bool areOverlapping = Raylib.CheckCollisionCircleRec(bullet_position, 15, barrier);

// if(areOverlapping == true)
//     {
//         for (int i = 0; i < bullets.Count; i++)
//         {
//             bullets.Remove($"Bullet{i}");
//         }
//     }