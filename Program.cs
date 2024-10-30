
Console.Write("(A)Ardışık-(B)ÇiftArdışık-(C)TekArdışık-(D)Faktoryiel-(E)Hepsi: "); /* Kullanıcıdan Seçim Yapmasını İstiyoruz */
string choise = Console.ReadLine();

Console.Write("Please Write a Number: "); /* Kullanıcıdan Sayı Seçmesini İstiyoruz */
int userNumber = Convert.ToInt32(Console.ReadLine());

int i;
int j;
int numberOne = 0;
int numberTwo = 1;

switch (choise)  /* Kullanıcının seçimine göre switch açılır, switch yerine if/else vb seçenekler kullanılabilir */
{
    case "A":

        for(i = 0; i <= userNumber; i++)           /**/
        {
            numberOne = numberOne + i;
        }

        Console.WriteLine(numberOne);     

    break;

    case "B":

        for(i = 0; i <= userNumber; i += 2)        /**/
        {
            numberOne = numberOne + i;
        }

        Console.WriteLine(numberOne);

    break;

        case "C":

        for(i = 1; i <= userNumber; i += 2)           /**/
        {
            numberOne = numberOne + i;
        }

        Console.WriteLine(numberOne);

    break;

        case "D":

        for(j = 1; j <= userNumber; j++)           /**/
        {
            numberTwo = numberTwo * j;
        }

        Console.WriteLine(numberTwo);

    break;

        case "E":

        for(j = 1; j <= userNumber; j++)           /**/
        {
            numberTwo = numberTwo * j;
        }

        Console.WriteLine(numberTwo);

        for(i = 1; i <= userNumber; i += 2)           /**/
        {
            numberOne = numberOne + i;
        }

        Console.WriteLine(numberOne);

        for(i = 0; i <= userNumber; i += 2)        /**/
        {
            numberOne = numberOne + i;
        }

        Console.WriteLine(numberOne);

        for(i = 0; i <= userNumber; i++)           /**/
        {
            numberOne = numberOne + i;
        }

        Console.WriteLine(numberOne);  

    break;
}       

