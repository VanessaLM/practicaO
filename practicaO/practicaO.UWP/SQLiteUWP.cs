﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using practicaO.UWP;
using Xamarin.Forms;
using Windows.Storage;

[assembly: Dependency(typeof(SQLiteUWP))]

namespace practicaO.UWP
{
    public class SQLiteUWP : ISQLite
    {
        public string GetLocalFilePath(string filename)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);
        }
    }
}
