using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Testing_cshrp
{
    internal class Task4
    {
        public enum State
        {
            Dead,
            Alive,
        }

        public static bool runGame = true;
        State[,] map = new State[5, 9];

        public void Game()
        {
            for (int i = 0; i < map.GetLength(0); i++)

                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = (State)RandomNumberGenerator.GetInt32(0, 2);
                }

            Console.CancelKeyPress += (sender, args) =>
            {
                runGame = false;
            };


            while (runGame)
            {
                
                if (EqualToNext(map, Next(map))==0)
                {
                    Print(map);
                    map = Next(map);
                    Console.ReadKey();
                } else
                {
                    Console.WriteLine("End of the game");
                    break;
                }
            }

        }

        static State[,] Next(State[,] current)
        {
            State[,] newGeneration = new State[5, 9];

            for (int i = 1; i < 4; i++)
                for (int j = 1; j <8; j++)
                {
                    int aliveNeighbors = 0;
                    for (int m = -1; m <= 1; m++)
                    {
                        for (int n = -1; n <= 1; n++)
                        {
                            aliveNeighbors += current[i + m, j + n] == State.Alive ? 1 : 0;
                        }
                    }

                    State currentCell = current[i, j];
                    aliveNeighbors -= currentCell == State.Alive ? 1 : 0;


                    if (currentCell == State.Alive && aliveNeighbors < 2)
                    {
                        newGeneration[i, j] = State.Dead;

                    } else if (currentCell == State.Alive && aliveNeighbors > 3)
                    {
                        newGeneration[i, j] = State.Dead;

                    } else if (currentCell == State.Dead && aliveNeighbors == 3)
                    {
                        newGeneration[i, j] = State.Alive;

                    }  else
                    {
                        newGeneration[i, j] = currentCell;
                    }
                }
            return newGeneration;
        }


        static void Print(State[,] future, int timeout = 1500)
        {
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    var cell = future[i, j];
                    stringBuilder.Append(cell == State.Alive ? "+" : "-");
                }
                stringBuilder.Append("\n");

            }
            stringBuilder.Append("\n");

            Console.Write(stringBuilder.ToString());
            Thread.Sleep(timeout);
        }

        int EqualToNext(State[,] map, State[,] nextMap)
        {
            int k = 0;
            for (int i=0; i < map.GetLength(0); i++)
            {
                for (int j=0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == nextMap[i, j])
                    {
                        k += 1;
                    }
                }
            }
            if (k == map.Length)
            {
                return 1;
            }
            return 0;
            
        }





        }
    
}
