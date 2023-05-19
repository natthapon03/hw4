class Program
{
class MainClass {
  public static void Main (string[] args) {
    string[] input = Console.ReadLine().Split(' ');
    int N = int.Parse(input[0]);
    int K = int.Parse(input[1]);

    string[] populationStr = Console.ReadLine().Split(' ');

    int[] population = new int[N];
    for (int i = 0; i < N; i++) {
      population[i] = int.Parse(populationStr[i]);
    }

    int maxCustomers = 0;
    for (int i = 0; i < N; i++) {
      int currentCustomers = 0;
   
      for (int j = Math.Max(0, i - K); j <= Math.Min(N - 1, i + K); j++) {
        currentCustomers += population[j];
      }
    
      maxCustomers = Math.Max(maxCustomers, currentCustomers);
    }

    Console.WriteLine(maxCustomers);
  }
}
}