class StudentGradingSystem
{
    static void Main()
    {
        Console.WriteLine("O'quvchilarni baholash tizimi");

        //  --> 1. O'quvchilar sonini kiritish uchun kod.
        int studentCount = 0;
        while (true)
        {
            Console.Write("O'quvchilar sonini kiriting: ");
            string input = Console.ReadLine()!;

            if (int.TryParse(input, out studentCount) && studentCount > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Iltimos, musbat butun son kiriting.");
            }
        }

        // --> 2. Baholarni kiritish uchu kod.
        int[] grades = new int[studentCount];
        Console.WriteLine($"Har bir o'quvchining bahosini kiriting (0 dan 100 gacha):");

        for (int i = 0; i < studentCount; i++)
        {
            while (true)
            {
                Console.Write($"O'quvchi {i + 1} bahosi: ");
                string gradeInput = Console.ReadLine()!;

                if (int.TryParse(gradeInput, out int grade) && grade >= 0 && grade <= 100)
                {
                    grades[i] = grade;
                    break;
                }
                else
                {
                    Console.WriteLine("Iltimos, 0 dan 100 gacha bo'lgan butun son kiriting.");
                }
            }
        }

        // --> 3. Eng yuqori va eng past bahoni topishga yordam beradi.
        int highestGrade = grades.Max();
        int lowestGrade = grades.Min();

        // --> 4. O'rtacha bahoni hisoblab beradi.
        double averageGrade = grades.Average();

        // --> 5. Reytingni chiqarish (kamayish tartibida saralanadi).
        int[] sortedGrades = (int[])grades.Clone();
        Array.Sort(sortedGrades);
        Array.Reverse(sortedGrades);

        Console.WriteLine("\nNatijalar:");
        Console.WriteLine($"Eng yuqori baho: {highestGrade}");
        Console.WriteLine($"Eng past baho: {lowestGrade}");
        Console.WriteLine($"O'rtacha baho: {averageGrade:F2}");
        Console.WriteLine("Reyting: " + string.Join(", ", sortedGrades));
    }
}
