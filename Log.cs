using System;
using System.IO;

public class Log
{
    private StreamWriter _Log;
    public readonly string FilePath;


    public Log(string FilePath = "Log.txt")
    {
        this.FilePath = FilePath;
        if (!File.Exists(this.FilePath))
            File.Create(this.FilePath).Close();
        this._Log = new StreamWriter(path: this.FilePath, append: true);
    }

    public void Append(string MethodName, string Message)
    {
        _Log.WriteLine($"{DateTime.Now}\t{ MethodName }\t{ Message }");
        _Log.Flush();
    }

    //save to xml
}
