using System;
using Vectors.Vectors;

namespace Vectors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrayVector = new ArrayVector(new int[] { 5, 7, 2, 4, 7 });

            var compressedVector = new CompressedVector(new (int, int)[] { (3, 1), (5, 1), (9, 3), (4, 2) });

            Console.WriteLine("Array Vector");
            Algorithms.PrintVector(arrayVector.GetEnumerator()); // arrayVector

            Console.WriteLine("Norm of vector (should be 11,958...)");
            Console.WriteLine(Algorithms.Norm(arrayVector.GetEnumerator())); // arrayVector

            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Compressed Vector");
            Algorithms.PrintVector(compressedVector.GetEnumerator()); // compressedVector

            Console.WriteLine("Norm of vector (should be 17,578...)");
            Console.WriteLine(Algorithms.Norm(compressedVector.GetEnumerator())); // compressedVector

            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Concatenation: arrayVector + compressedVector");
            Algorithms.PrintVector(Algorithms.Concatenate(arrayVector.GetEnumerator(), compressedVector.GetReverseEnumerator()).GetEnumerator()); // arrayVector + compressedVector

            Console.WriteLine("Concatenation: compressedVector + arrayVector");
            Algorithms.PrintVector(Algorithms.Concatenate(compressedVector.GetEnumerator(), arrayVector.GetReverseEnumerator()).GetEnumerator());
        }
    }
}
