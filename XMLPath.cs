using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

public class XMLPaths
{
    private Dictionary<string, string> Paths;
    private StreamWriter _Log;
    public readonly string FilePath;


    public XMLPaths(string FilePath = "Path.txt")
    {
        //this.FilePath = FilePath;
        //if (!File.Exists(this.FilePath))
        //    File.Create(this.FilePath).Close();
        //this._Log = new StreamWriter(path: this.FilePath, append: true);

    }
}
