//using System;

//namespace IO_Exceptions
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i = 5;
//            int j = 0;
//            double res = 0;
//            //res = i / j; //meta exception
//            try
//            {
//                //pavojingas kodas, kuris gali ismesti exception. Reikalingas komentaras
//                res = i / j;
//            }
//            catch //arba finally

//            //catch gaudo visus exception (catch(Exception))
//            {
//                Console.WriteLine("You cannot devide by zero");
//                Environment.Exit(0);
//            }
//            Console.WriteLine(res);
//        }
//    }
//}

//using System;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;

//public class Program
//{
//    public static void Main()
//    {
//        // unhandeled exception event handler

//        AppDomain currentDomain = AppDomain.CurrentDomain;
//        currentDomain.UnhandledException += (s, ea) => Console.WriteLine($"Doing something, sender:  {s}, event args: {ea}");
//        //kad suveiktu, reikia kad uzsiglusintu del nesuhandlinto exception



//        Console.WriteLine("Enter 1, 2, 3, 4, 5: ");
//        string userChoice = Console.ReadLine();

//        var rx = new Regex(@"^[1-5]$", RegexOptions.IgnoreCase);
//        while (!rx.IsMatch(userChoice))
//        {
//            Console.WriteLine("... please provide a valid input!");
//            userChoice = Console.ReadLine();
//        }

//        MethodThatThrows(userChoice);

//        //try
//        //{
//        //    dynamic _ = userChoice switch
//        //    {
//        //        "1" => throw new ArgumentException(),
//        //        "2" => throw new DivideByZeroException(),
//        //        "3" => throw new Exception(),
//        //        "4" => 4,
//        //        _ => throw new NotImplementedException(),
//        //    };
//        //}
//        //catch (DivideByZeroException)
//        //{
//        //    Console.WriteLine("no division by 0");
//        //    Console.WriteLine("... performing additional work!");

//        //}
//        //catch (ArgumentException)
//        //{
//        //    Console.WriteLine("Incoreect argumentation");

//        //}
//        //catch (Exception)
//        //{
//        //    Console.WriteLine("PLS check yourself");
//        //}

//        //finally
//        ////try finally - visada pasidarys finally, nesvarbu,  buvo exception ar ne
//        //{
//        //    Console.WriteLine("Finally!");
//        //}

//        Console.WriteLine("Will we reach this?");
//    }
//    static void MethodThatThrows(string userChoice)
//    {
//        try
//        {
//            dynamic _ = userChoice switch
//            {
//                "1" => throw new ArgumentException(),
//                "2" => throw new DivideByZeroException(),
//                "3" => throw new Exception(),
//                "4" => 4,
//                "5" => throw new CustomException(),
//                _ => throw new NotImplementedException(),
//            };
//        }
//        catch (DivideByZeroException ex) when (ex.Message.Contains("Jonas"))
//        {
//            Console.WriteLine("no division by 0");
//            Console.WriteLine("... performing additional work!");
//            Console.WriteLine(ex);

//            //rethrowing

//            //throw ex; //praradome info exception stacktrace informacijoje, nelieka originalios eilutes pirmojo exception karto, nedaroma
//            //throw; //correct way



//            //wrapping

//            //throw new DivideByZeroException("Papildomas message, kuris patikslina, kas nutiko", ex)

//        }
//        catch (DivideByZeroException ex) when (ex.Message.Contains("zero"))
//        {
//            Console.WriteLine("no NO NO division by 0");
//            Console.WriteLine("... performing additional work!");
//            Console.WriteLine("... PAGAVAU SU FILTRIUKU!");
//            Console.WriteLine(ex);

//            //rethrowing

//            //throw ex; //praradome info exception stacktrace informacijoje, nelieka originalios eilutes pirmojo exception karto, nedaroma
//            //throw; //correct way



//            //wrapping

//            //throw new DivideByZeroException("Papildomas message, kuris patikslina, kas nutiko", ex)

//        }
//        catch (ArgumentException)
//        {
//            Console.WriteLine("Incoreect argumentation");

//        }
//        catch (CustomException ex)
//        {
//            Console.WriteLine($"Custom exception: {ex}");
//            ex.Data.Add("message", "Take care of this for me!");
//            Console.WriteLine($"Custom exception: {ex.Data["message"]}");
//        }
//        catch (Exception)
//        {
//            Console.WriteLine("PLS check yourself");
//        }

//        finally
//        //try finally - visada pasidarys finally, nesvarbu,  buvo exception ar ne
//        {
//            Console.WriteLine("Finally!");
//        }
//    }

//    //custom exception
//    class CustomException : Exception
//    {
//        private const string defaultMessage = "sth bad happened";

//        public CustomException() : base(defaultMessage)
//        {

//        }

//        public CustomException(string message) : base(message)
//        {
//        }

//        public CustomException(string message, Exception innerException) : base(message, innerException)
//        {
//        }




//    }
//}


// Uzd.:
//Turime mūsų draugą skaičiuotuvo appsą - jums reikės tik klasės Calculator ir metodas int Add(int i, int j). Klausimai:
//Ar yra situacija, kurioje gali prireikti šiame metode mesti exception? 
//Kokia tai situacija? 
//Kokį exception mesti? 
//Ar galime išspręsti šią situaciją be exception? Tarkim su return code ar out parametrais?
//… Suprogramuokite.




//using System;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;

//public class Program
//{
//    public static void Main()
//    {
//        Calculator();
//    }
//    static void Calculator()
//    {
//        //Console.WriteLine("Please use the calculator");
//        //Console.WriteLine("Your first number is");
//        //int firstNumber = CheckIfValid(Console.ReadLine());
//        //Console.WriteLine("Your second number is");
//        //int secondNumber = CheckIfValid(Console.ReadLine());
//        //Console.WriteLine("The answer is");
//        //Console.WriteLine(Add(firstNumber, secondNumber));
//        //Console.WriteLine(Add(int.MaxValue, int.MaxValue));
//        Console.WriteLine(Add(int.MinValue, int.MinValue));

//    }
//    static int CheckIfValid(string input)
//    {
//        bool guessIsInt = int.TryParse(input, out int answer);
//        while (guessIsInt is false)
//        {
//            Console.WriteLine("Please write a correct number");
//            input = Console.ReadLine();
//            guessIsInt = int.TryParse(input, out answer);
//        }
//        return answer;
//    }
//    //static int Add(int i, int j)
//    //{
//    //    int sum = i + j;
//    //    return sum;
//    //}
//    static int Add(int i, int j)
//    {
//        if (int.MaxValue - i == 0 || int.MaxValue - j == 0) throw new OverflowException();
//        else if (int.MinValue + i == 0 || int.MinValue + j == 0) throw new UnderflowException();
//        else return i + j;
//    }
//    class UnderflowException : Exception
//    {
//        private const string defaultException = "Arithmetic operation resulted in an underflow.'";
//        public UnderflowException() : base(defaultException)
//        {
//        }

//        public UnderflowException(string message) : base(defaultException)
//        {
//        }

//        public UnderflowException(string message, Exception innerException) : base(defaultException, innerException)
//        {
//        }
//    }
//}
















// I-O  (input-output)

//using System;
//using System.IO;

//namespace IO_Exceptions
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //0. creating directories
//            //Directory.CreateDirectory(@"C:\Users\Vartotojas\OneDrive - UAB Baltijos Polistirenas\Desktop\Kita\Kodinam\DotNetKursas\Created_W_C#");
//            //Directory.CreateDirectory(@".\Created_W_C#");
//            //Directory.CreateDirectory(@"..\Created_W_C#");

//            ////1. file
//            //File.Create(@".\out\test.txt"); // nera subdir, kol rankiniu budu nesukuriau

//            ////2. file excist
//            //Console.WriteLine(File.Exists(@".\out\test.txt"));
//            //Console.WriteLine(File.Exists(@".\out\kaka.txt"));
//            //Console.WriteLine(Directory.Exists(@".\out"));

//            ////3. path
//            //Console.WriteLine(Path.IsPathFullyQualified(@".\out"));
//            //Console.WriteLine(Path.IsPathFullyQualified(@"C:\Users\Vartotojas\OneDrive - UAB Baltijos Polistirenas\Desktop\Kita\Kodinam\DotNetKursas"));
//            //Console.WriteLine(Path.IsPathFullyQualified(@"C:\Users\Vartotojas\OneDrive - UAB Baltijos Polistirenas\Desktop\Kita\Kodinam\NESAMONEEEEE"));

//            ////4. get name
//            //Console.WriteLine(new DirectoryInfo(@".\out").Parent.FullName);
//            //Console.WriteLine(new DirectoryInfo(@".\out").Parent.Parent.FullName);

//            ////5. Path combine
//            //Console.WriteLine(Path.Combine(@"C:\Users\Vartotojas\OneDrive - UAB Baltijos Polistirenas\Desktop\Kita\Kodinam\DotNetKursas", "another_folder"));

//            ////6. file copy
//            ////string srcPath = @"C:\Users\Vartotojas\OneDrive - UAB Baltijos Polistirenas\Desktop\Kita\Kodinam\DotNetKursas\Csharp\IO_Exceptions\bin\Debug\net5.0\out\test1.txt";
//            ////string dstPath = @"C:\Users\Vartotojas\OneDrive - UAB Baltijos Polistirenas\Desktop\Kita\Kodinam\DotNetKursas\Csharp\IO_Exceptions\bin\Debug\net5.0\dest\test1.txt";

//            ////File.Copy(dstPath, srcPath);
//            ////File.Move(srcPath, dstPath);
//            ////File.Move(srcPath, dstPath, true); //leidzia overridinti

//            ////7.
//            //Console.WriteLine(string.Join("\n", Directory.GetFiles(@".")));
//            //Console.WriteLine(string.Join("\n", Directory.GetDirectories(@".")));

//            ////8.
//            ////Directory.Delete(@".\out");
//            ////Directory.Delete(@".\dest", true);

//            ////9.

//            //FileInfo fileInfo = new FileInfo(@".\out\test.txt");
//            //Console.WriteLine(fileInfo.CreationTime);


//            //uzdavinukas

//            string srcPath = @".\out";
//            string srcFilePath = @".\out\test1.txt";
//            string dstPath = @".\dest\";
//            string dstFilePath = @".\dest\test1.txt";

//            if(Directory.Exists(srcPath) is false)
//            {
//                Console.WriteLine("Source directory doesn't exist");
//                Environment.Exit(0);
//            }

//            //File.Move(srcFilePath, dstFilePath);

//            try
//            {
//                File.Move(srcFilePath, dstFilePath);
//            }
//            catch (FileNotFoundException a) when (a.Message.Contains(@"out\test1.txt"))
//            {
//                Console.WriteLine("The source file does not exist");
//            }
//            catch (DirectoryNotFoundException)
//            {
//                Console.WriteLine("Destination directory doesn't exist");
//            }
//            catch (IOException a) when (a.Message.Contains("Cannot create a file when that file already exists"))
//            {
//                FileInfo sourceFileInfo = new FileInfo(srcFilePath);
//                FileInfo destinationFileInfo = new FileInfo(dstFilePath);
//                if(sourceFileInfo.CreationTime == destinationFileInfo.CreationTime)
//                {
//                    File.Move(srcFilePath, dstFilePath, true);
//                }
//                else
//                {
//                    Console.WriteLine("Files have same name, but different creation time, please check them before moving");
//                    //taisyti
//                }

//            }


//        }
//    }
//}








// ARGS prisimenam
//using System;
//using System.IO;
//using static System.Console;

//namespace DataProcessor
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            WriteLine("Parsing command line options");

//            // Command line validation omitted for brevity

//            string path = Path.GetFullPath(args[0]);
//            WriteLine(path);


//            var command = args[0];

//            if (command == "--file")
//            {
//                var filePath = args[1];
//                // Check if path is absolute
//                if (!Path.IsPathFullyQualified(filePath))
//                {
//                    WriteLine($"ERROR: path '{filePath}' must be fully qualified.");
//                    ReadLine();
//                    return;
//                }

//                WriteLine($"Single file {filePath} selected");
//                ProcessSingleFile(filePath);
//            }
//            else if (command == "--dir")
//            {
//                var directoryPath = args[1];
//                var fileType = args[2];
//                WriteLine($"Directory {directoryPath} selected for {fileType} files");
//                ProcessDirectory(directoryPath, fileType);
//            }
//            else
//            {
//                WriteLine("Invalid command line options");
//            }

//            WriteLine("Press enter to quit.");
//            ReadLine();
//        }

//        private static void ProcessSingleFile(string filePath)
//        {
//            var fileProcessor = new FileProcessor(filePath);
//            fileProcessor.Process();
//        }

//        private static void ProcessDirectory(string directoryPath, string fileType)
//        {
//            switch (fileType)
//            {
//                case "TEXT":
//                    string[] textFiles = Directory.GetFiles(directoryPath, "*.txt");
//                    foreach (var textFilePath in textFiles)
//                    {
//                        var fileProcessor = new FileProcessor(textFilePath);
//                        fileProcessor.Process();
//                    }
//                    break;
//                default:
//                    WriteLine($"ERROR: {fileType} is not supported");
//                    return;
//            }
//        }
//    }

//    class FileProcessor
//    {
//        private const string BackupDirectoryName = "backup";
//        private const string InProgressDirectoryName = "processing";
//        private const string CompletedDirectoryName = "complete";

//        public string InputFilePath { get; }

//        public FileProcessor(string filePath) => InputFilePath = filePath;

//        public void Process()
//        {
//            WriteLine($"Begin process of {InputFilePath}");

//            // Check if file exists
//            if (!File.Exists(InputFilePath))
//            {
//                WriteLine($"ERROR: file {InputFilePath} does not exist.");
//                return;
//            }

//            string rootDirectoryPath = new DirectoryInfo(InputFilePath).Parent.Parent.FullName;
//            WriteLine($"Root data path is {rootDirectoryPath}");

//            // Check if backup dir exists
//            string backupDirectoryPath = Path.Combine(rootDirectoryPath, BackupDirectoryName);

//            //if (!Directory.Exists(backupDirectoryPath))
//            //{
//            WriteLine($"Attempting to create {backupDirectoryPath}");
//            Directory.CreateDirectory(backupDirectoryPath);
//            //}

//            // Copy file to backup dir
//            string inputFileName = Path.GetFileName(InputFilePath);
//            string backupFilePath = Path.Combine(backupDirectoryPath, inputFileName);
//            WriteLine($"Copying {InputFilePath} to {backupFilePath}");
//            File.Copy(InputFilePath, backupFilePath, true);

//            // Move to in progress dir
//            Directory.CreateDirectory(Path.Combine(rootDirectoryPath, InProgressDirectoryName));
//            string inProgressFilePath =
//                Path.Combine(rootDirectoryPath, InProgressDirectoryName, inputFileName);

//            if (File.Exists(inProgressFilePath))
//            {
//                WriteLine($"ERROR: a file with the name {inProgressFilePath} is already being processed.");
//                return;
//            }

//            WriteLine($"Moving {InputFilePath} to {inProgressFilePath}");
//            File.Move(InputFilePath, inProgressFilePath);


//            // Determine type of file
//            string extension = Path.GetExtension(InputFilePath);

//            switch (extension)
//            {
//                case ".txt":
//                    ProcessTextFile(inProgressFilePath);
//                    break;
//                default:
//                    WriteLine($"{extension} is an unsupported file type.");
//                    break;
//            }

//            // Move file after processing is complete
//            string completedDirectoryPath = Path.Combine(rootDirectoryPath, CompletedDirectoryName);
//            Directory.CreateDirectory(completedDirectoryPath);
//            WriteLine($"Moving {inProgressFilePath} to {completedDirectoryPath}");
//            //File.Move(inProgressFilePath, Path.Combine(completedDirectoryPath, inputFileName));

//            string completedFileName =
//                $"{Path.GetFileNameWithoutExtension(InputFilePath)}-{Guid.NewGuid()}{extension}";

//            //completedFileName = Path.ChangeExtension(completedFileName, ".complete");

//            var completedFilePath = Path.Combine(completedDirectoryPath, completedFileName);

//            File.Move(inProgressFilePath, completedFilePath);

//            string inProgressDirectoryPath = Path.GetDirectoryName(inProgressFilePath);
//            Directory.Delete(inProgressDirectoryPath, true);
//        }

//        private void ProcessTextFile(string inProgressFilePath)
//        {
//            WriteLine($"Processing text file {inProgressFilePath}");
//            // Read in and process
//        }
//    }
//}




//using System;
//using System.IO;
//using System.Text.RegularExpressions;

//namespace IO_Exceptions
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //0.
//            Console.WriteLine(File.ReadAllText(@".\out\test1.txt"));
//            Console.WriteLine(File.ReadAllText(@".\out\test1.docx"));

//            //1.
//            var lines = File.ReadAllLines(@".\out\test1.txt");
//            Console.WriteLine(string.Join("\n", lines));

//            Console.WriteLine("");
//            foreach (var line in lines)
//            {
//                if (new Regex(@"^(.+)\1$").IsMatch(line))
//                    Console.WriteLine(line);
//            }

//            //2. binary irgi galima

//            //3. Write vs append
//            //File.Create(@"out\test_append_write.txt");
//            var path2 = @"out\test_append_write.txt";
//            File.WriteAllLines(path2, new string[] { "this", "is", "write" });
//            File.WriteAllLines(path2, new string[] { "another", "line" });

//            File.AppendAllLines(path2, new string[] { "this", "is", "write" });
//            File.AppendAllLines(path2, new string[] { "another", "line" });

//            //4. unicodde vs utf-8
//            var path = @".\out\test_utf8.txt";
//            File.WriteAllLines(path2, new string[] { "Lietuviški rašmenys" });
//            File.WriteAllLines(path2, new string[] { "Lietuviški rašmenys" }, System.Text.Encoding.ASCII);
//            File.WriteAllLines(path2, new string[] { "Lietuviški rašmenys" }, System.Text.Encoding.Latin1);

//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.InputEncoding = System.Text.Encoding.UTF8;

//            Console.WriteLine("ŠŪDAS");
//            string test = Console.ReadLine();
//            Console.WriteLine(test);

//        }
//    }
//}



//You have a text file with names written one per line.
//Using C# count the most frequently occurring (i.e. “popular”) name -
//write the most popular name to the console.


//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text.RegularExpressions;

//namespace IO_Exceptions
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var lines = File.ReadAllLines(@".\out\names.txt");
//            Dictionary<string, int> nameToCount = new Dictionary<string, int> { };
//            for (int i = 0; i < lines.Length; i++)
//            {
//                //Console.WriteLine(lines[i].ToString());
//                if (nameToCount.ContainsKey(lines[i]) is false)
//                {
//                    int counter = 1;
//                    nameToCount.Add(lines[i], counter);
//                }
//                else
//                {
//                    nameToCount[lines[i]]++;
//                }

//            }
//            foreach (var item in nameToCount)
//            {
//                Console.WriteLine($"{{{item.Key} {item.Value}}}");
//            }
//        }
//        }
//    }







//CSV
using System;
using System.Text.RegularExpressions;
using static System.IO.File;
using static System.Console;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;
using System.Globalization;
using CsvHelper;

class Program
{
    static void Main(string[] args)
    {
        //_1ex_SimpleTools();
        //_2ex_TextFieldParser();
        //_3rd_CsvHelper();
    }

    static void _1ex_SimpleTools()
    {
        var ages = new List<int>();
        using (StreamReader sr = new StreamReader(@".\out\csv.csv"))
        {
            string currentLine;
            int lineCounter = 0;
            while ((currentLine = sr.ReadLine()) != null)
            {
                if (lineCounter++ == 0)
                    continue;
                var datafields = currentLine.Split(',');
                ages.Add(int.Parse(datafields[^1]));
            }
        }

        Console.WriteLine(calcAverage(ages));
    }

    static void _2ex_TextFieldParser()
    {
        using (TextFieldParser parser = new TextFieldParser(@".\out\csv.csv"))
        {
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            while (!parser.EndOfData)
            {
                if (parser.LineNumber == 1)
                {
                    parser.ReadFields();
                    continue;
                }

                string[] fields = parser.ReadFields();
                foreach (string field in fields)
                {
                    Console.WriteLine(field);
                }
            }
        }
    }

    static void _3rd_CsvHelper()
    {
        using (var reader = new StreamReader(@".\out\csv.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<dynamic>();
            foreach (var record in records)
            {
                Console.WriteLine(record.id);
                Console.WriteLine(record.name);
                Console.WriteLine(record.age);
            }
        }
    }

    static double calcAverage(List<int> arr)
    {
        int sum = 0;
        foreach (var n in arr)
            sum += n;

        return sum / arr.Count;
    }
}

