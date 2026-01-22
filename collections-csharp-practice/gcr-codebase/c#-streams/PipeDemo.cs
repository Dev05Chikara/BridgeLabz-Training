using System;
using System.IO.Pipes;
using System.Threading;

class PipeDemo
{
    static void Main()
    {
        AnonymousPipeServerStream server =
            new AnonymousPipeServerStream(PipeDirection.Out);

        Thread reader = new Thread(() =>
        {
            AnonymousPipeClientStream client =
                new AnonymousPipeClientStream(PipeDirection.In, server.ClientSafePipeHandle);

            using (StreamReader sr = new StreamReader(client))
                Console.WriteLine(sr.ReadLine());
        });

        reader.Start();

        using (StreamWriter sw = new StreamWriter(server))
        {
            sw.AutoFlush = true;
            sw.WriteLine("Hello from Writer");
        }

        reader.Join();
    }
}
