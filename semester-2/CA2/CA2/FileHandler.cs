/****************************************************************************
*   Filename    :   FileHandler.cs                                          *
*   Author      :   Brian McGowan / S00165159                               *
*   Date        :   29/03/2016                                              *
*   Type        :   Submission for in-class asessment CA1                   *
****************************************************************************/
using System;
using System.Collections.Generic;
using System.IO;

namespace CA2
{
    class FileHandler
    {
        public static List<SalesPerson> LoadFromFile()
        {
            FileStream fs = new FileStream("sales.txt", FileMode.Open, FileAccess.Read);
            StreamReader inputStream = new StreamReader(fs);

            List<SalesPerson> salesPeople = new List<SalesPerson>();
            string lineIn;

            while ((lineIn = inputStream.ReadLine()) != null)
            {
                string[] elements = lineIn.Split(',');
                int sales = Convert.ToInt32(elements[3]);
                SalesPerson sp = new SalesPerson(elements[1].Trim(), elements[0].Trim(), elements[2].Trim(), sales);
                salesPeople.Add(sp);
            }
            inputStream.Close();
            return salesPeople;
        }
    }
}
