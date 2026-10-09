bool found = false;
long n = 1;
List<string> cubes = [];
while (found == false)
{
    char[] cube = (n*n*n).ToString().ToCharArray();
    Array.Sort(cube);
    string sorted = new string(cube);
    cubes.Add(sorted);
    int count = 0;
    foreach (string key in cubes)
    {
        if (key == sorted)
        {
            count++;
        }
    }
    if (count == 5)
    {
        for (long i = 1; i <= n; i++)
        {
            long checkCube = i * i * i;
            char[] checkDigits = checkCube.ToString().ToCharArray();
            Array.Sort(checkDigits);
            if (new string(checkDigits) == sorted)
            {
                Console.WriteLine(checkCube);
                found = true;
                break;
            }
        }
    }
    n++;

}

