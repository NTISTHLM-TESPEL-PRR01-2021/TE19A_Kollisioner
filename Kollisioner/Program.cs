using System;
using Raylib_cs;

namespace Kollisioner
{
  class Program
  {
    static void Main(string[] args)
    {

      Raylib.InitWindow(800, 600, "Kollisoner");

      Rectangle playerRect = new Rectangle(0, 0, 100, 50);
      Rectangle enemyRect = new Rectangle(50, 60, 30, 30);

      Color red = new Color(255, 0, 0, 128);

      while (!Raylib.WindowShouldClose())
      {
        //playerRect.x += 0.1f;
        playerRect.y += 0.01f;

        Raylib.BeginDrawing();

        Raylib.ClearBackground(Color.LIGHTGRAY);

        Raylib.DrawRectangleRec(playerRect, red);
        Raylib.DrawRectangleRec(enemyRect, red);

        if (Raylib.CheckCollisionRecs(playerRect, enemyRect))
        {
          Raylib.DrawText("Colliding!", 0, 550, 32, Color.BLACK);
        }

        Raylib.EndDrawing();
      }

    }
  }
}
