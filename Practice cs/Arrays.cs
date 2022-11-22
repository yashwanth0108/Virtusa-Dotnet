// C# program to check if there exists a pair
using System;
class Cs{

	static bool chkPair(int[] A, int size, int x)
	{
		for (int i = 0; i < (size - 1); i++) {
			for (int j = (i + 1); j < size; j++) {
				if (A[i] + A[j] == x) {
					return true;
				}
			}
		}

		return false;
	}

	public static void Main()
	{
		int[] A = { 0, -1, 2, -3, 1 };
		int x = -2;
		int size = A.Length;

		if (chkPair(A, size, x)) {
			Console.WriteLine("Yes");
		}
		else {
			Console.WriteLine("No");
		}
	}
}


