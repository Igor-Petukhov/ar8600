// Use this code inside a project created with the Visual C# > Windows Desktop > Console Application template.
// Replace the code in Program.cs with this code.

using System;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.IO;
using NAudio.Wave;

public class AR8600
{
    static byte[] data = new byte[50];
    static bool _continue;
    static SerialPort _serialPort;
    static int is_logger_on = 0;
    static FileStream file_stream = null;
    static StreamWriter stream_writer = null;
    static WaveFileWriter waveFile;
    static string unswer = "";

    public static void Read()
    {
        while (_continue)
        {
            try
            {
               unswer = _serialPort.ReadLine();
               Console.WriteLine(unswer);
            }
            catch (TimeoutException) { }
        }
    }
    public static void Main()
    {
        _serialPort = new System.IO.Ports.SerialPort();
        Thread readThread = new Thread(Read);
        string tmp_str, tmp_str_modulation, tmp_scan_f = "something", tmp_scan_m = "something";
        int choise = -1, tmp = -1, tmp_modulation = 0, time_delay = 800;
        StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;

        //Если существует конфигурационный файл - считаем настройки из него
        if (File.Exists("settings.txt"))
        {
            Console.WriteLine("Считываются из конфигурационного файла настройки подключения");
            try
            {
                using (FileStream fs = new FileStream("settings.txt", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
                    {
                        _serialPort.PortName = sr.ReadLine(); //Имя порта
                        _serialPort.BaudRate = Int32.Parse(sr.ReadLine());
                        _serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), sr.ReadLine(), true);
                        _serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), sr.ReadLine(), true);
                        _serialPort.DataBits = Int32.Parse(sr.ReadLine());
                        _serialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), sr.ReadLine(), true);

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Считывание завершено.");
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Для соединения со сканером необходимо ввести настройки подключения. Создастся файл настроек settings.txt.");
            // Allow the user to set the appropriate properties.
            Console.WriteLine("Стандартные настройки соединения:\n\tPortName = COM3\n\tBaudRate = 9600\n\tParity = None\n\tStopBits = Two\n\tDataBits = 8\n\tHandshake = XOnXOff");
            // Пользователь введёт настройки и мы их сохраним в файл

            using (FileStream fs = new FileStream("settings.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    _serialPort.PortName = SetPortName(_serialPort.PortName);
                    sw.WriteLine(_serialPort.PortName);

                    _serialPort.BaudRate = SetPortBaudRate(_serialPort.BaudRate);
                    sw.WriteLine(_serialPort.BaudRate);

                    _serialPort.Parity = SetPortParity(_serialPort.Parity);
                    sw.WriteLine(_serialPort.Parity);

                    _serialPort.StopBits = SetPortStopBits(_serialPort.StopBits);
                    sw.WriteLine(_serialPort.StopBits);

                    _serialPort.DataBits = SetPortDataBits(_serialPort.DataBits);
                    sw.WriteLine(_serialPort.DataBits);

                    _serialPort.Handshake = SetPortHandshake(_serialPort.Handshake);
                    sw.WriteLine(_serialPort.Handshake);
                }
            }
            Console.WriteLine("Настройки сохранены в файл settings.txt\nДля продолжения введите любой символ.");
            Console.ReadKey();
            Console.Clear();
        }

        _serialPort.ReadTimeout = 500;
        _serialPort.WriteTimeout = 500;

        try
        {
            _serialPort.Open(); //Открыть com-port
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.ReadKey();
            return;
        }
        
        _continue = true;
        readThread.Start();

        WaveInEvent waveSource = new WaveInEvent();
        waveSource.WaveFormat = new WaveFormat(44100, 1);
        waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);

        while (_continue)
        {
            Console.WriteLine("         Программа управления радиосканером AR8600        ");
            Console.WriteLine("==========================================================");
            Console.WriteLine("                           МЕНЮ                           ");
            Console.WriteLine("==========================================================");
            Console.WriteLine("0 - выйти из программы");
            Console.WriteLine("1 - \\r");
            Console.WriteLine("2 - выключить сканер");
            Console.WriteLine("3 - закрыть соединение");
            Console.WriteLine("4 - показать текущее состояние");
            Console.WriteLine("5 - настроиться на частоту");
            Console.WriteLine("6 - настроить подключение сканера через com port (RS232)");
            Console.WriteLine("7 - включить ведение журнала (логирование)");
            Console.WriteLine("8 - записать до нажатия клавиши Enter");
            Console.WriteLine("9 - вернуть частоту и уровень когда открыт шумодав");
            Console.WriteLine("10 - задать режим модуляции");
            Console.WriteLine("11 - запустить сканирование частот заданных в файле \"scan_list.txt\"");
            Console.WriteLine("==========================================================");
            
            try
            {
                choise = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                choise = -1;
            }
            Console.Clear();
            if (choise == 0)
            {
                _continue = false;
                data = Encoding.ASCII.GetBytes("EX\r"); //Перевести строку в байты
                _serialPort.Write(data, 0, data.Length);
            }
            else
            {
                switch (choise)
                {
                    case 1:
                        Send_to_logfile("Отправляю сканеру комманду \\r конец строки");
                        data = Encoding.ASCII.GetBytes("\r"); //Перевести строку в байты
                        _serialPort.Write(data, 0, data.Length);
                        break;
                    case 2://2 - выключить сканер
                        Send_to_logfile("Отправляю сканеру комманду QP\\r выключить сканер");
                        data = Encoding.ASCII.GetBytes("QP\r"); //Перевести строку в байты
                        _serialPort.Write(data, 0, data.Length);
                        break;
                    case 3://3 - закрыть соединение
                        Send_to_logfile("Отправляю сканеру комманду EX\\r закрыть соединение");
                        data = Encoding.ASCII.GetBytes("EX\r"); //Перевести строку в байты
                        _serialPort.Write(data, 0, data.Length);
                        break;
                    case 4://4 - показать текущее состояние
                        Send_to_logfile("Отправляю сканеру комманду RX\\r показать текущее состояние");
                        data = Encoding.ASCII.GetBytes("RX\r"); //Перевести строку в байты
                        _serialPort.Write(data, 0, data.Length);
                        break;
                    case 5://5 - настроиться на частоту
                        Console.WriteLine("Введите частоту в МГц формата: NNNN.NNNNA, где A = \"5\" (частота будет кончаться на 50 Гц) или А = \"0\".");
                        tmp_str = Console.ReadLine();
                        Send_to_logfile("Отправляю сканеру комманду RF" + tmp_str + "\\r настроиться на частоту");
                        data = Encoding.ASCII.GetBytes("RF" + tmp_str + "\r"); //Перевести строку в байты
                        _serialPort.Write(data, 0, data.Length);
                        Console.Clear();
                        break;
                    case 6://6 - настроить подключение сканера через com port (RS232)
                        Send_to_logfile("Пользователь выбрал пункт \"настроить подключение сканера через com port (RS232)\"");
                        Console.WriteLine("ВНИМАНИЕ! Для применения настроек потребуется перезапустить программу!");
                        Console.WriteLine("Стандартные настройки соединения:\n\tPortName = COM3\n\tBaudRate = 9600\n\tParity = None\n\tStopBits = Two\n\tDataBits = 8\n\tHandshake = XOnXOff");
                        Console.WriteLine("Вводите значения так, как они отображены.");
                        // Пользователь введёт настройки и мы их сохраним в файл

                        using (FileStream fs = new FileStream("settings.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read))
                        {
                            using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                            {
                                sw.WriteLine(SetPortName(_serialPort.PortName));
                                sw.WriteLine(SetPortBaudRate(_serialPort.BaudRate));
                                sw.WriteLine(SetPortParity(_serialPort.Parity));
                                sw.WriteLine(SetPortStopBits(_serialPort.StopBits));
                                sw.WriteLine(SetPortDataBits(_serialPort.DataBits));
                                sw.WriteLine(SetPortHandshake(_serialPort.Handshake));
                            }
                        }
                        Console.Clear();
                        break;
                    case 7://7 - включить ведение журнала (логирование)
                        Send_to_logfile("Пользователь выбрал пункт \"включить ведение журнала (логирование)\"");
                        Console.WriteLine("Включить ведение журнала (логирование)?");
                        Console.WriteLine("1 - да");
                        Console.WriteLine("2 - нет");
                        try
                        {
                            tmp = Int32.Parse(Console.ReadLine());
                        }
                        catch (Exception e2)
                        {
                            Console.WriteLine(e2.Message);
                            break;
                        }
                        switch (tmp)
                        {
                            case 1:
                                is_logger_on = 1;
                                file_stream = new FileStream("log.txt", FileMode.Create, FileAccess.Write, FileShare.Read);
                                stream_writer = new StreamWriter(file_stream, Encoding.Unicode);
                                break;
                            case 2:
                                break;
                            default:
                                break;
                        }
                        Console.Clear();
                        break;
                    case 8://8 - записать до нажатия клавиши Enter
                        Console.WriteLine("Записываю до нажатия клавиши Enter...");
                        Send_to_logfile("Записываю до нажатия клавиши Enter");

                        
                        waveFile = new WaveFileWriter("test.wav", waveSource.WaveFormat);
                        waveSource.StartRecording();
                        Console.WriteLine("Press enter to stop");
                        Console.ReadLine();
                        waveSource.StopRecording();
                        waveFile.Dispose();

                        Console.Clear();
                        break;
                    case 9://9 - вернуть частоту и уровень когда открыт шумодав
                        Send_to_logfile("Отправляю сканеру комманду LC1\\r вернуть частоту и уровень когда открыт шумодав");
                        data = Encoding.ASCII.GetBytes("LC1\r"); //Перевести строку в байты
                        _serialPort.Write(data, 0, data.Length);
                        break;
                    case 10://10 - задать режим модуляции
                        Console.WriteLine("Задать модуляцию:");
                        Console.WriteLine("1 - WFM");
                        Console.WriteLine("2 - NFM");
                        Console.WriteLine("3 - AM");
                        Console.WriteLine("4 - USB");
                        Console.WriteLine("5 - LSB");
                        Console.WriteLine("6 - CW");
                        Console.WriteLine("7 - SFM");
                        Console.WriteLine("8 - WAM");
                        Console.WriteLine("9 - NAM");
                        tmp_modulation = Int32.Parse(Console.ReadLine());
                        switch (tmp_modulation)
                        {
                            case 1:
                                tmp_str_modulation = "0";
                                break;
                            case 2:
                                tmp_str_modulation = "1";
                                break;
                            case 3:
                                tmp_str_modulation = "2";
                                break;
                            case 4:
                                tmp_str_modulation = "3";
                                break;
                            case 5:
                                tmp_str_modulation = "4";
                                break;
                            case 6:
                                tmp_str_modulation = "5";
                                break;
                            case 7:
                                tmp_str_modulation = "6";
                                break;
                            case 8:
                                tmp_str_modulation = "7";
                                break;
                            case 9:
                                tmp_str_modulation = "8";
                                break;
                            default:
                                tmp_str_modulation = "";
                                break;
                        }
                        Send_to_logfile("Отправляю сканеру комманду MD" + tmp_str_modulation + "\\r задать режим модуляции");
                        data = Encoding.ASCII.GetBytes("MD" + tmp_str_modulation + "\r"); //Перевести строку в байты
                        _serialPort.Write(data, 0, data.Length);
                        Console.Clear();
                        break;
                    case 11://11 - запустить сканирование частот заданных в файле \"scan_list.txt\"
                        Directory.CreateDirectory("Recordings");
                        for (int i = 0; i < 3; i++)
                        {
                            using (FileStream fs3 = new FileStream("scan_list.txt", FileMode.Open, FileAccess.Read, FileShare.Read))
                            {
                                using (StreamReader sr3 = new StreamReader(fs3, Encoding.Unicode))
                                {
                                    while (!sr3.EndOfStream)
                                    {

                                        //Устанавливаем частоту
                                        ////////////////////////
                                        tmp_scan_f = sr3.ReadLine(); //frequency
                                        Console.WriteLine("считали частоту из файла: " + tmp_scan_f);
                                        data = Encoding.ASCII.GetBytes("RF" + tmp_scan_f + "\r"); //Перевести строку в байты
                                        _serialPort.Write(data, 0, data.Length);
                                        Thread.Sleep(time_delay);
                                        data = Encoding.ASCII.GetBytes("LC1\r"); //просим показать нам установленную частоту и уровень
                                        _serialPort.Write(data, 0, data.Length);
                                        Thread.Sleep(time_delay);
                                        while (long.Parse(unswer.Substring(unswer.Length - 11).Remove(9)) != long.Parse((tmp_scan_f.Replace(".",""))))
                                        {
                                            Console.WriteLine(long.Parse(unswer.Substring(unswer.Length - 11).Remove(9)));
                                            Console.WriteLine(long.Parse((tmp_scan_f.Replace(".", ""))));

                                            Thread.Sleep(time_delay);
                                            data = Encoding.ASCII.GetBytes("LC0\r"); //отключаем показывание частоты при превышении сквелча
                                            _serialPort.Write(data, 0, data.Length);

                                            Thread.Sleep(time_delay);
                                            data = Encoding.ASCII.GetBytes("LC1\r"); //просим показать нам установленную частоту и уровень
                                            _serialPort.Write(data, 0, data.Length);
                                            
                                            Thread.Sleep(time_delay);
                                            //Console.WriteLine("unswer.Substring(unswer.Length - 11) = " + unswer.Substring(unswer.Length - 11).Remove(10));
                                            //Console.WriteLine("Считали из файла = " + tmp_scan_f.Replace(".", ""));
                                        }
                                        Thread.Sleep(time_delay);
                                        data = Encoding.ASCII.GetBytes("LC0\r"); //отключаем показывание частоты при превышении сквелча
                                        _serialPort.Write(data, 0, data.Length);

                                        //Устанавливаем модуляцию
                                        ////////////////////////////
                                        tmp_scan_m = sr3.ReadLine(); //modulation
                                        Console.WriteLine("считали модуляцию из файла: " + tmp_scan_m);
                                        
                                        switch (tmp_scan_m)
                                        {
                                            case "WFM":
                                                while (unswer != "MD0\r")
                                                {
                                                    data = Encoding.ASCII.GetBytes("MD0\r"); //Перевести строку в байты
                                                    _serialPort.Write(data, 0, data.Length);
                                                    Thread.Sleep(time_delay);
                                                    data = Encoding.ASCII.GetBytes("MD\r"); //Перевести строку в байты
                                                    _serialPort.Write(data, 0, data.Length);
                                                    Thread.Sleep(time_delay);
                                                }
                                                break;
                                            case "NFM":
                                                while (unswer != "MD1\r")
                                                {
                                                    data = Encoding.ASCII.GetBytes("MD1\r"); //Перевести строку в байты
                                                    _serialPort.Write(data, 0, data.Length);
                                                    Thread.Sleep(time_delay);
                                                    data = Encoding.ASCII.GetBytes("MD\r"); //Перевести строку в байты
                                                    _serialPort.Write(data, 0, data.Length);
                                                    Thread.Sleep(time_delay);
                                                }
                                                break;
                                            case "AM":
                                                while (unswer != "MD2\r")
                                                {
                                                    data = Encoding.ASCII.GetBytes("MD2\r"); //Перевести строку в байты
                                                    _serialPort.Write(data, 0, data.Length);
                                                    Thread.Sleep(time_delay);
                                                    data = Encoding.ASCII.GetBytes("MD\r"); //Перевести строку в байты
                                                    _serialPort.Write(data, 0, data.Length);
                                                    Thread.Sleep(time_delay);
                                                }
                                                break;
                                            case "USB":
                                                while (unswer != "MD3\r")
                                                {
                                                    data = Encoding.ASCII.GetBytes("MD3\r"); //Перевести строку в байты
                                                    _serialPort.Write(data, 0, data.Length);
                                                    Thread.Sleep(time_delay);
                                                    data = Encoding.ASCII.GetBytes("MD\r"); //Перевести строку в байты
                                                    _serialPort.Write(data, 0, data.Length);
                                                    Thread.Sleep(time_delay);
                                                }
                                                break;
                                            case "LSB":
                                                while (unswer != "MD4\r")
                                                {
                                                    data = Encoding.ASCII.GetBytes("MD4\r"); //Перевести строку в байты
                                                    _serialPort.Write(data, 0, data.Length);
                                                    Thread.Sleep(time_delay);
                                                    data = Encoding.ASCII.GetBytes("MD\r"); //Перевести строку в байты
                                                    _serialPort.Write(data, 0, data.Length);
                                                    Thread.Sleep(time_delay);
                                                }
                                                break;
                                            case "CW":
                                                while (unswer != "MD5\r")
                                                {
                                                    data = Encoding.ASCII.GetBytes("MD5\r"); //Перевести строку в байты
                                                    _serialPort.Write(data, 0, data.Length);
                                                    Thread.Sleep(time_delay);
                                                    data = Encoding.ASCII.GetBytes("MD\r"); //Перевести строку в байты
                                                    _serialPort.Write(data, 0, data.Length);
                                                    Thread.Sleep(time_delay);
                                                }
                                                break;
                                            case "SFM":
                                                while (unswer != "MD6\r")
                                                {
                                                    data = Encoding.ASCII.GetBytes("MD6\r"); //Перевести строку в байты
                                                    _serialPort.Write(data, 0, data.Length);
                                                    Thread.Sleep(time_delay);
                                                    data = Encoding.ASCII.GetBytes("MD\r"); //Перевести строку в байты
                                                    _serialPort.Write(data, 0, data.Length);
                                                    Thread.Sleep(time_delay);
                                                }
                                                break;
                                            case "WAM":
                                                while (unswer != "MD7\r")
                                                {
                                                    data = Encoding.ASCII.GetBytes("MD7\r"); //Перевести строку в байты
                                                    _serialPort.Write(data, 0, data.Length);
                                                    Thread.Sleep(time_delay);
                                                    data = Encoding.ASCII.GetBytes("MD\r"); //Перевести строку в байты
                                                    _serialPort.Write(data, 0, data.Length);
                                                    Thread.Sleep(time_delay);
                                                }
                                                break;
                                            case "NAM":
                                                while (unswer != "MD8\r")
                                                {
                                                    data = Encoding.ASCII.GetBytes("MD8\r"); //Перевести строку в байты
                                                    _serialPort.Write(data, 0, data.Length);
                                                    Thread.Sleep(time_delay);
                                                    data = Encoding.ASCII.GetBytes("MD\r"); //Перевести строку в байты
                                                    _serialPort.Write(data, 0, data.Length);
                                                    Thread.Sleep(time_delay);
                                                }
                                                break;
                                            default:
                                                break;
                                        }
                                        
                                        Thread.Sleep(time_delay);
                                        //show frequency and level
                                        data = Encoding.ASCII.GetBytes("LC1\r"); //Перевести строку в байты
                                        _serialPort.Write(data, 0, data.Length);
                                        Thread.Sleep(time_delay);
                                        Console.WriteLine("ответ сканера " + unswer);
                                        data = Encoding.ASCII.GetBytes("\r"); //Перевести строку в байты
                                        Thread.Sleep(time_delay);


                                        //Записываем звук 3 секунды
                                        ///////////////////////////
                                        Console.WriteLine("-------start audio recording for 3 seconds------");
                                        
                                        waveFile = new WaveFileWriter("Recordings\\" + tmp_scan_f + "MHz_" + DateTime.Now.ToString().Replace(" ", "_").Replace(":","'") + ".wav", waveSource.WaveFormat);
                                        waveSource.StartRecording();
                                        Thread.Sleep(3000);
                                        waveSource.StopRecording();
                                        waveFile.Dispose();

                                        Console.Clear();
                                    }


                                }
                            }
                        }

                                
                        break;
                    default:
                        break;
                }
                
            }
            
        }
        readThread.Join();
        _serialPort.Close();
        if (is_logger_on == 1)
        {
            if (stream_writer != null)
                stream_writer.Close();
            if (file_stream != null)
                file_stream.Close();
            is_logger_on = 0;
        }

    }

    // Display Port values and prompt user to enter a port.
    public static string SetPortName(string defaultPortName)
    {
        string portName;

        Console.WriteLine("Доступные порты:");
        foreach (string s in SerialPort.GetPortNames())
        {
            Console.WriteLine("   {0}", s);
        }

        Console.Write("Введите COM значение порта (напимер так: COM1) (По умолчанию: {0}): ", defaultPortName);
        portName = Console.ReadLine();

        if (portName == "" || !(portName.ToLower()).StartsWith("com"))
        {
            portName = defaultPortName;
        }
        return portName;
    }
    // Display BaudRate values and prompt user to enter a value.
    public static int SetPortBaudRate(int defaultPortBaudRate)
    {
        string baudRate;

        Console.Write("Baud Rate(default:{0}): ", defaultPortBaudRate);
        baudRate = Console.ReadLine();

        if (baudRate == "")
        {
            baudRate = defaultPortBaudRate.ToString();
        }

        return int.Parse(baudRate);
    }

    // Display PortParity values and prompt user to enter a value.
    public static Parity SetPortParity(Parity defaultPortParity)
    {
        string parity;

        Console.WriteLine("Available Parity options:");
        foreach (string s in Enum.GetNames(typeof(Parity)))
        {
            Console.WriteLine("   {0}", s);
        }

        Console.Write("Enter Parity value (Default: {0}):", defaultPortParity.ToString(), true);
        parity = Console.ReadLine();

        if (parity == "")
        {
            parity = defaultPortParity.ToString();
        }

        return (Parity)Enum.Parse(typeof(Parity), parity, true);
    }
    // Display DataBits values and prompt user to enter a value.
    public static int SetPortDataBits(int defaultPortDataBits)
    {
        string dataBits;

        Console.Write("Enter DataBits value (Default: {0}): ", defaultPortDataBits);
        dataBits = Console.ReadLine();

        if (dataBits == "")
        {
            dataBits = defaultPortDataBits.ToString();
        }

        return int.Parse(dataBits.ToUpperInvariant());
    }

    // Display StopBits values and prompt user to enter a value.
    public static StopBits SetPortStopBits(StopBits defaultPortStopBits)
    {
        string stopBits;

        Console.WriteLine("Available StopBits options:");
        foreach (string s in Enum.GetNames(typeof(StopBits)))
        {
            Console.WriteLine("   {0}", s);
        }

        Console.Write("Enter StopBits value (None is not supported and \n" +
         "raises an ArgumentOutOfRangeException. \n (Default: {0}):", defaultPortStopBits.ToString());
        stopBits = Console.ReadLine();

        if (stopBits == "")
        {
            stopBits = defaultPortStopBits.ToString();
        }

        return (StopBits)Enum.Parse(typeof(StopBits), stopBits, true);
    }
    public static Handshake SetPortHandshake(Handshake defaultPortHandshake)
    {
        string handshake;

        Console.WriteLine("Available Handshake options:");
        foreach (string s in Enum.GetNames(typeof(Handshake)))
        {
            Console.WriteLine("   {0}", s);
        }

        Console.Write("Enter Handshake value (Default: {0}):", defaultPortHandshake.ToString());
        handshake = Console.ReadLine();

        if (handshake == "")
        {
            handshake = defaultPortHandshake.ToString();
        }

        return (Handshake)Enum.Parse(typeof(Handshake), handshake, true);
    }

    public static void Send_to_logfile(string text)
    {
        if (is_logger_on == 1)
        {
            stream_writer.WriteLine(DateTime.Now.ToString() + " " + text);
        }
    }
    static void waveSource_DataAvailable(object sender, WaveInEventArgs e)
    {
        waveFile.WriteData(e.Buffer, 0, e.BytesRecorded);
    }

}