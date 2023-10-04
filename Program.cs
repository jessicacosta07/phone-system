// TODO: Realizar os testes com as classes Nokia e Iphone

using phone_system.Models;

Console.WriteLine("Smartphone Nokia");
Nokia n1 = new Nokia(numero: "1234", modelo: "Modelo 1", imei: "11111111", memoria: 64);
n1.Ligar();
n1.InstalarAplicativo("Telegram");

Console.WriteLine("Smartphone Iphone");
Iphone i1 = new Iphone(numero: "5678", modelo: "Modelo 2", imei: "22222222", memoria: 256);
i1.ReceberLigacao();
i1.InstalarAplicativo("Slack");