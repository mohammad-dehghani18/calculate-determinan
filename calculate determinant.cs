//mohammad dehghani project


using system;
namespace project
{
	class Program
	{
		static void Main(string[] args)
		{
		
            int [,] matrix= new int [3,3];
            int determinant;
            Console.WriteLine("please enter matrix elements:");
            for (int i=0;i<=2;i++)
            {
                for (int j=0;j<=2;j++)
                {
                    Console.WriteLine("element [{0},{1}] = ", i, j);
                    matrix[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            determinant = 
            (matrix[0,0]*((matrix[1,1]*matrix[2,2])-(matrix[1,2]*matrix[2,1])))-(matrix[0,1]*((matrix[1,0]*matrix[2,2])-(matrix[1,2]*matrix[2,0])))+(matrix[0,2]*((matrix[1,0]*matrix[2,1])-(matrix[1,1]*matrix[2,0])));
        Console.WriteLine("determinant = {0}",determinant);
		}
	}
}