// Заполните спирально массив 4 на 4
namespace matrix
{
    class Program {
        static void Main() {
            Console.Write(" n = ");
            int N = int.Parse(Console.ReadLine());//границы снизу и сверху, границы слева и спава
           
 
            int[,] NN = new int[N, N];            
            int row = 0, col = 0, dx = 0, dy = 1, dirChanges = 0, gran = N;
            int l =  NN.Length;
            for(int i = 0; i < l; i++) {
                NN[row, col] = i + 1;
 
                if(--gran == 0) {
                    gran = N * (dirChanges % 2) + N * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                    int temp = dy;
                    dy = -dx;
                    dx = temp;
                    dirChanges++;
                }
 
                col += dx;
                row += dy;
            }
                        
            N = NN.GetLength(1);
            for(int k = 0; k < l; k++)
                Console.Write("{0}{1,3}", k % N == 0 ? "\n" : "", NN[k / N, k % N]);
 
 
            Console.ReadLine();
        }
    }
}
