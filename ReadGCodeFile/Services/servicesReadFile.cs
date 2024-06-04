using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadGCodeFile.Interfaces;

namespace ReadGCodeFile.Services
{
    public class servicesReadFile : IReadFile
    {
        string? newLine;
        public string FileReading(Stream fileStream,string searchingString,string repString)
        {
            var fileContent = string.Empty;

            string path = "C:\\Temp\\GCode\\NewgCode.cnc";


            try
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    /*Read All File to the End.*/
                    fileContent = reader.ReadToEnd();

                    /*Split to the read file.*/
                    string[] Valus = fileContent.Split("\r\n");

                    /*Read String from the g code file.*/
                    StringReader stringReader = new StringReader(fileContent);

                    /*Loop for the items will show to user interface.*/
                    foreach (string Val in Valus)
                    {
                      
                        if (Val != null)
                        {
                            /*Check G54 Variables*/
                            if (Val.Contains(searchingString))
                            {
                                string v = Val.Replace(Val, repString);
                                newLine = v;

                            }
                            else
                            {
                                newLine = " ";
                                return newLine;

                            }
                           
                        }

                    }

                    return newLine;

                    foreach (string Val in Valus)
                    {
                        using (StreamWriter streamWriter = new StreamWriter(path))
                        {
                            string nVal = string.Concat(Val, "\r\n");
                            streamWriter.WriteLine(nVal);

                        }
                    }

                }


              

            }
            catch (Exception)
            {

                throw;
            }



        }
    }
}
