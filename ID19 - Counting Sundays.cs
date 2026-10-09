int[] months = [31,28,31,30,31,30,31,31,30,31,30,31]; 
int firstday = 2;
int count = 0;
for (int year = 1901; year <= 2000; year++)
{
    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
        {
            months[1] = 29;
        }
    else
        {
            months[1] = 28;
        }
    for (int month = 0; month <= 11; month++)
    {
        if (firstday == 1 )
        {
            count++;
        }
        firstday = months[month] % 7 + firstday;
        if (firstday > 7)
        {
            firstday = firstday - 7;
        } 
    }
}
Console.Write(count);