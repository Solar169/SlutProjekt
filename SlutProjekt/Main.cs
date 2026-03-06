using Raylib_cs;


Raylib.InitWindow(800, 600, "slutprojekt");
Raylib.SetTargetFPS(30);

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.White);

    Raylib.DrawCircle(400, 300, 100, Color.Violet);

    Raylib.EndDrawing();
}