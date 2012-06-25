using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata002
{
    class Program
    {
        bool band;
        int[,] matriz = new int[,] { { -1, 0, -1 }, { 0, 0, 0 }, { -1, 0, -1}};
        static void Main(string[] args)
        {
            Program p = new Program();
            p.retornar_busqueda();
        }

    public void inicializarmatriz()
        { 
            pintarmina();
        }

        public void pintarmina() 
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3 ; j++)
                {
                    Console.Write( matriz[i,j] + "\n");
                }
            }
            Console.ReadLine();
        }

        public void retornar_busqueda() 
        {
              for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    if (matriz[i, j] == -1)
                    {
                        checkPosAndSetValue(i - 1, j - 1, 3, 3);
                        checkPosAndSetValue(i, j-1, 3, 3);
                        checkPosAndSetValue(i+1,j-1, 3, 3);
                        checkPosAndSetValue(i-1,j, 3, 3);
                        checkPosAndSetValue(i+1, j, 3, 3);
                        checkPosAndSetValue(i-1, j+1, 3, 3);
                        checkPosAndSetValue(i, j+1, 3, 3);
                        checkPosAndSetValue(i+1, j + 1, 3, 3);
                    }
                    /*if ( matriz[i,j] == -1)
                    { 
                          if(i == 0 & j==0) 
                            { 
                            matriz[i,j+1]=matriz[i,j+1]+1;
                            matriz[i+1,j]=matriz[i+1,j]+1;
                            matriz[i+1,j+1]=matriz[i+1,j+1]+1;
                              }

                          if (i == 0 & j == 1)
                          {
                              matriz[i, j - 1] = matriz[i, j - 1] + 1;
                              matriz[i, j + 1] = matriz[i, j + 1] + 1;
                              matriz[i + 1, j - 1] = matriz[i + 1, j - 1] + 1;
                              matriz[i + 1, j] = matriz[i + 1, j] + 1;
                              matriz[i + 1, j + 1] = matriz[i + 1, j + 1] + 1;
                          }

                          if (i == 0 & j == 2)
                          {
                              matriz[i, j + 1] = matriz[i, j + 1] + 1;
                              matriz[i + 1, j] = matriz[i + 1, j] + 1;
                              matriz[i + 1, j + 1] = matriz[i + 1, j + 1] + 1;
                          }


                          if (i == 0 & j == 0)
                          {
                              matriz[i, j + 1] = matriz[i, j + 1] + 1;
                              matriz[i + 1, j] = matriz[i + 1, j] + 1;
                              matriz[i + 1, j + 1] = matriz[i + 1, j + 1] + 1;
                          }
                    }*/
                }
            }
         pintarmina2();
        }

        public bool checkPosAndSetValue(int i, int j, int width, int height)
        {
            if (i >= 0 && j >= 0 && (i <= (width - 1)) && (j <= (height -1 ))) {
                if (matriz[i, j] != -1)
                {
                    matriz[i, j] += 1;
                    band = true;
                }
            }
            return band;
        }

      public void pintarmina2()
        {
            Console.Write("-----------Busca Mina------------- \n\n\n");
            Console.Write("----------------------- \n");
          for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matriz[i, j] == -1)
                    {
                        Console.Write("*" + " ");
                    }
                    else
                    {
                        Console.Write(matriz[i, j] + " ");
                    }
                }
                Console.Write("\n");
            }
          Console.Write("----------------------- \n");
            Console.ReadLine();
        }

    }
}
