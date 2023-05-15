using System;
using System.Collections.Generic;
using System.Linq;


namespace M05_UF3_P3_Frogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeManager.timer.Start();
            Player ranita = new Player();


            List<Lane> lines = new List<Lane>();

            lines.Add(new Lane(posY: 0, speedPlayer: false, background: ConsoleColor.DarkGreen, damageElements: false, damageBackground: false, elementsPercent: 0f, elementsChar: Utils.charLogs, colorsElements: Utils.colorsCars.ToList()));
            lines.Add(new Lane(posY: 1, speedPlayer: true, background: ConsoleColor.DarkBlue, damageElements: false, damageBackground: true, elementsPercent: 0.9f, elementsChar: Utils.charLogs, colorsElements: Utils.colorsCars.ToList()));
            lines.Add(new Lane(posY: 2, speedPlayer: true, background: ConsoleColor.DarkBlue, damageElements: false, damageBackground: true, elementsPercent: 0.7f, elementsChar: Utils.charLogs, colorsElements: Utils.colorsCars.ToList()));
            lines.Add(new Lane(posY: 3, speedPlayer: true, background: ConsoleColor.DarkBlue, damageElements: false, damageBackground: true, elementsPercent: 0.8f, elementsChar: Utils.charLogs, colorsElements: Utils.colorsCars.ToList()));
            lines.Add(new Lane(posY: 4, speedPlayer: true, background: ConsoleColor.DarkBlue, damageElements: false, damageBackground: true, elementsPercent: 0.9f, elementsChar: Utils.charLogs, colorsElements: Utils.colorsCars.ToList()));
            lines.Add(new Lane(posY: 5, speedPlayer: true, background: ConsoleColor.DarkBlue, damageElements: false, damageBackground: true, elementsPercent: 0.7f, elementsChar: Utils.charLogs, colorsElements: Utils.colorsCars.ToList()));
            lines.Add(new Lane(posY: 6, speedPlayer: false, background: ConsoleColor.DarkGreen, damageElements: false, damageBackground: false, elementsPercent: 0f, elementsChar: Utils.charLogs, colorsElements: Utils.colorsCars.ToList()));
            lines.Add(new Lane(posY: 7, speedPlayer: false, background: ConsoleColor.Black, damageElements: true, damageBackground: false, elementsPercent: 0.1f, elementsChar: Utils.charCars, colorsElements: Utils.colorsCars.ToList()));
            lines.Add(new Lane(posY: 8, speedPlayer: false, background: ConsoleColor.Black, damageElements: true, damageBackground: false, elementsPercent: 0.2f, elementsChar: Utils.charCars, colorsElements: Utils.colorsCars.ToList()));
            lines.Add(new Lane(posY: 9, speedPlayer: false, background: ConsoleColor.Black, damageElements: true, damageBackground: false, elementsPercent: 0.2f, elementsChar: Utils.charCars, colorsElements: Utils.colorsCars.ToList()));
            lines.Add(new Lane(posY: 10, speedPlayer: false, background: ConsoleColor.Black, damageElements: true, damageBackground: false, elementsPercent: 0.2f, elementsChar: Utils.charCars, colorsElements: Utils.colorsCars.ToList()));
            lines.Add(new Lane(posY: 11, speedPlayer: false, background: ConsoleColor.Black, damageElements: true, damageBackground: false, elementsPercent: 0.1f, elementsChar: Utils.charCars, colorsElements: Utils.colorsCars.ToList()));
            lines.Add(new Lane(posY: 12, speedPlayer: false, background: ConsoleColor.DarkGreen, damageElements: true, damageBackground: false, elementsPercent: 0f, elementsChar: Utils.charCars, colorsElements: Utils.colorsCars.ToList()));


            while (true)
            {
                
                Utils.GAME_STATE gamestate = Utils.GAME_STATE.RUNNING;
                while (gamestate == Utils.GAME_STATE.RUNNING)
                {
                    Console.Clear();                   
                    foreach (Lane lane in lines)
                    {
                        lane.Draw();
                        lane.Update();
                        
                    }
                    ranita.Draw(lines);
                    Vector2Int inputs = Utils.Input();
                    gamestate = ranita.Update(inputs, lines);
                    Console.BackgroundColor = ConsoleColor.Black;
                    TimeManager.NextFrame();
                }
                Console.Clear();
                if(gamestate == Utils.GAME_STATE.WIN)
                {
                    Console.WriteLine("YOU WIN !!!");
                }
                else if (gamestate == Utils.GAME_STATE.LOOSE)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOU LOST..");
                }
                Console.ReadKey();
                
            }
   
        }
    }
}
