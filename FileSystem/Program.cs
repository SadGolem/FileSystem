Console.WriteLine("Введите 1 - вывести данные на экран, введите 2 - заполнить данные и добавить новую запись.");

string input = Console.ReadLine();
string path = @"D:\Project_Visual\Skillbox\6\File-System-Skillbox6\FileSystem Skillbox6\FileSystem Skillbox6\bin\Debug\net7.0\data.txt";

if (input == "2")
{
    int id;
    if (File.Exists(path))
    {
        id = File.ReadLines(path).Count();
    }
    else
    {
        id = 0;
    }
    StreamWriter streamWriter = new StreamWriter("data.txt", true); //создание потока для работы с файлом



    streamWriter.Write(id + "#");


    streamWriter.Write(DateTime.Now + "#");

    Console.WriteLine("Введите ФИО");
    streamWriter.Write(Console.ReadLine() + "#");

    Console.WriteLine("Введите возраст");
    streamWriter.Write(Console.ReadLine() + "#");

    Console.WriteLine("Введите дату рождения");
    streamWriter.Write(Console.ReadLine() + "#");

    Console.WriteLine("Введите место рождения");
    streamWriter.WriteLine(Console.ReadLine() + "#");

    streamWriter.Flush(); //очистка буфера 
    streamWriter.Close();
}
else if (input == "1")
{
    using (StreamReader streamReader = new StreamReader("data.txt"))
    {
        while (!streamReader.EndOfStream)
        {
            Console.WriteLine(streamReader.ReadLine());
        }
        streamReader.Close();
    }

}
else
{
    Console.WriteLine("Неизвестный ввод.");
}