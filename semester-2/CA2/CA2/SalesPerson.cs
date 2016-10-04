/****************************************************************************
*   Filename    :   SalesPerson.cs                                          *
*   Author      :   Brian McGowan / S00165159                               *
*   Date        :   29/03/2016                                              *
*   Type        :   Submission for in-class asessment CA1                   *
****************************************************************************/
namespace CA2
{
    public class SalesPerson
    {
        public SalesPerson() { }

        public SalesPerson(string name, string number, string nationality, int sales)
        {
            string[] elems = name.Split(' ');
            FirstName = elems[0];
            LastName = elems[1];
            Number = number;
            Nationality = nationality;
            Sales = sales;
            SetRating();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }

        public string Number { get; set; }

        public string Nationality { get; set; }

        public string StarRating { get; set; }

        public int Sales { get; set; }

        public string InitialSurname
        {
            get
            {
                return string.Format("{0}, {1}", FirstName.Substring(0, 1).ToUpper(), LastName);
            }
        }

        public string Initials
        {
            get
            {
                string format = "{0}. {1}.";
                return string.Format(format, FirstName.Substring(0, 1).ToUpper(), LastName.Substring(0, 1).ToUpper());
            }
        }


        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", FullName, Nationality, Number, Sales, StarRating);
        }

        private void SetRating()
        {
            if (Sales < CA2.ONE_STAR)
                StarRating = "*";
            else if (Sales < CA2.TWO_STAR)
                StarRating = "**";
            else if (Sales < CA2.THREE_STAR)
                StarRating = "***";
            else if (Sales < CA2.FOUR_STAR)
                StarRating = "****";
            else StarRating = "*****";
        }
    }
}
