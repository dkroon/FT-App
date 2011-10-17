using System;
using System.IO;
using System.Collections;
using System.Globalization;
/** Copyright (C) 2008  Dallas Kroon

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

namespace FTAppWM6
{
    public class FileManager
    {
        private IFormatProvider culture = new CultureInfo("en-US", true);
        private String[] header = null;
        public string badLine; // in case of a Format Exception, holds the line containing the problem
        public int badLineCount; // in case of a Format Exception, holds the line number 
        public FileManager()
        {
        }

        public EntityRecord[] GetEntityRecords(String fullyQualifiedFilename) 
        {
            ArrayList myList = new ArrayList();
            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(fullyQualifiedFilename);
            while ((line = file.ReadLine()) != null)
            {
                EntityRecord er = new EntityRecord();
                string[] itemArray = line.Split('\t');
                if (counter == 0) { header = itemArray; }
                if (counter > 0)
                {
                    er.EntityID = itemArray[0];
                    try
                    {
                        if (itemArray[1].Length > 1)
                        {
                            er.AnthesisDate = DateTime.Parse(itemArray[1]);
                            //er.AnthesisDate = DateTime.ParseExact(itemArray[1], "MM/dd/yy", culture, DateTimeStyles.NoCurrentDateDefault);
                        }
                        //if (itemArray[2].Length > 1)
                        //{
                        //    er.AnthesisScorer = itemArray[2];
                        //}
                        //if (itemArray[3].Length > 1)
                        //{
                        //    er.AnthesisDateStamp = DateTime.ParseExact(itemArray[3], "MM/dd/yyyy HH:mm:ss", culture, DateTimeStyles.NoCurrentDateDefault);
                        //}
                        if (itemArray[2].Length > 1)
                        {
                            er.SilkingDate = DateTime.Parse(itemArray[2]);
                            //er.SilkingDate = DateTime.ParseExact(itemArray[2], "MM/dd/yy", culture, DateTimeStyles.NoCurrentDateDefault);
                        }
                        //if (itemArray[5].Length > 1)
                        //{
                        //    er.SilkingScorer = itemArray[5];
                        //}
                        //if (itemArray[6].Length > 1)
                        //{
                        //    er.SilkingDateStamp = DateTime.ParseExact(itemArray[6], "MM/dd/yyyy HH:mm:ss", culture, DateTimeStyles.NoCurrentDateDefault);
                        //}
                    }
                    catch (FormatException fe) 
                    {
                        badLine = line;
                        badLineCount = counter;
                        throw (fe); 
                    }
                }
                myList.Add(er);
                counter++;
            }

            file.Close();
            object[] myArray = myList.ToArray();

            EntityRecord[] entityRecord = new EntityRecord[myArray.Length];
            for (int i = 1; i < myArray.Length; i++)
            {
                entityRecord[i] = (EntityRecord)myArray[i];
            }
            return entityRecord;
        }


        public void SaveEntityRecords(String fullyQualifiedFilename, EntityRecord[] erIn)
        {
            System.IO.StreamWriter fileOut = new System.IO.StreamWriter(fullyQualifiedFilename);
            String headerRow = header[0];
            for (int i = 1; i < header.Length; i++)
            {
                headerRow = headerRow + "\t" + header[i];
            }
            fileOut.WriteLine(headerRow);
            for (int i = 1; i < erIn.Length; i++)
            {
                fileOut.WriteLine(erIn[i].ToString());
            }
            fileOut.Flush();
            fileOut.Close();
        }
    }
}