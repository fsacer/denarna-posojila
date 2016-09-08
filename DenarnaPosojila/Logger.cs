using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace DenarnaPosojila
{
    //beleženje prijav in odjav
    public enum LoggerAction { Prijava, Odjava}
    public static class Logger
    {
        public static string datoteka = @"loginLog.txt";
        public static void Log(LoggerAction akcija, string userName)
        {
            try 
            {
                using (FileStream fs = File.Open(datoteka, FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    if (akcija == LoggerAction.Prijava)
                    {
                        string vrstica = String.Format("[{0}] Uporabnik {1} se je prijavil v aplikacijo Denarna Posojila.", DateTime.Now, userName);
                        sw.WriteLine(vrstica);
                    }
                    else if (akcija == LoggerAction.Odjava) 
                    {
                        string vrstica = String.Format("[{0}] Uporabnik {1} se je odjavil iz aplikacije Denarna Posojila.", DateTime.Now, userName);
                        sw.WriteLine(vrstica);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Napaka pri beleženju!", "Beleženje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
