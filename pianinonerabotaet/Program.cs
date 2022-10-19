Console.WriteLine("Чтобы запустить программу нажмите стрелочку вверх или стрелочку вниз");


int[] octav4 = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
int[] octav5 = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
int[] octav6 = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865,1975 };

int position = 1;
ConsoleKeyInfo key = Console.ReadKey();

while (key.Key != ConsoleKey.Enter)
{

    if (key.Key == ConsoleKey.UpArrow)
    {
        position--;  


    }
    if (key.Key == ConsoleKey.DownArrow)
    {

        position++; 

    }

    Console.Clear();
    Console.WriteLine(" Какая октава вам нужна?");
    Console.WriteLine("    4я октава");
    Console.WriteLine("    5я октава");
    Console.WriteLine("    6я октава");
    Console.WriteLine("    Чтобы выйти - выбери меня ");
    Console.SetCursorPosition(0, position);
    Console.Write("-->");

    key = Console.ReadKey();

}
if (position == 1)
{
    Console.SetCursorPosition(0, 6);
    Console.WriteLine("Четвертая октава");
    Octava(octav4);

}
if (position == 2)
{
    Console.SetCursorPosition(0, 6);
    Console.WriteLine("Пятая октава");
    Octava(octav5);
}
if (position == 3)
{
    Console.SetCursorPosition(0, 6);
    Console.WriteLine("Шестая октава");
    Octava(octav6);
}


void Octava(int[] selectedOctave)
{

    ConsoleKeyInfo keyForNotes = Console.ReadKey();

    while (keyForNotes.Key != ConsoleKey.Escape)
    {


        if (keyForNotes.Key == ConsoleKey.E)
        {

            Console.Beep(selectedOctave[0], 500);

        }
        if (keyForNotes.Key == ConsoleKey.R)
        {

            Console.Beep(selectedOctave[1], 500);

        }
        if (keyForNotes.Key == ConsoleKey.T)
        {

            Console.Beep(selectedOctave[2], 500);

        }
        if (keyForNotes.Key == ConsoleKey.Y)
        {

            Console.Beep(selectedOctave[3], 500);

        }
        if (keyForNotes.Key == ConsoleKey.U)
        {

            Console.Beep(selectedOctave[4], 500);

        }
        if (keyForNotes.Key == ConsoleKey.I)
        {

            Console.Beep(selectedOctave[5], 500);

        }
        if (keyForNotes.Key == ConsoleKey.D)
        {

            Console.Beep(selectedOctave[6], 500);

        }
        if (keyForNotes.Key == ConsoleKey.F)
        {

            Console.Beep(selectedOctave[7], 500);

        }
        if (keyForNotes.Key == ConsoleKey.G)
        {

            Console.Beep(selectedOctave[8], 500);

        }
        if (keyForNotes.Key == ConsoleKey.H)
        {

            Console.Beep(selectedOctave[9], 500);

        }
        if (keyForNotes.Key == ConsoleKey.J)
        {

            Console.Beep(selectedOctave[10], 500);

        }
        if (keyForNotes.Key == ConsoleKey.K)
        {

            Console.Beep(selectedOctave[11], 500);

        }
        keyForNotes = Console.ReadKey();
    }

}
