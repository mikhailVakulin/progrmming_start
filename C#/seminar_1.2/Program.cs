int N = Convert.ToInt32(Console.ReadLine());
int negativeN = N *(-1); // -n - negativeN
// от negativeN = -4 до N = 4
while (negativeN <= N)
{
    Console.WriteLine(negativeN);
    negativeN = negativeN + 1;
    // negativeN += 1
    // negativeN++; - инкремент
    // negativeN--; negativeN = negativeN - 1 - декремент 
}
