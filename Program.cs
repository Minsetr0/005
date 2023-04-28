Random random = new Random();
int maxRandomNumber = 4;
int minRandomNumber = 0;
int arrayLength = 30;
int[] array = new int[arrayLength];
int repeats = 0;
int answerRepeats = 0;
int answerRepeatingNumber = 0;
int repeatingNumber = 0;
int tempRepeatingNumber = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(minRandomNumber, maxRandomNumber);
    Console.Write(array[i] + " ");
}

tempRepeatingNumber = array[0];

for (int i = 0; i < arrayLength; i++)
{
    if (array[i] == tempRepeatingNumber)
    {
        repeats++;

        if (repeats > answerRepeats)
        {
            answerRepeats = repeats;
            answerRepeatingNumber = tempRepeatingNumber;
        }
    }
    else if (array[i] != tempRepeatingNumber)
    {
        repeats = 1;
        tempRepeatingNumber = array[i];
    }
}

Console.WriteLine("Число " + answerRepeatingNumber + "повторяется " + answerRepeats + "раз.");