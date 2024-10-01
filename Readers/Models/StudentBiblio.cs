using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readers.Models
{
    public class StudentBiblio
    {
        public StudentBiblio() { }

        public string FIO { get; set; }

        public string Pin { get; set; }

        public string Code { get; set; }

        public string Email { get; set; }

        public string Employment { get; set; }

        public string Course { get; set; }

        public string Cost1 { get; set; } //Должность

        public string Notes {  get; set; }

        public string IsBlocked {  get; set; }

        public string IsReadyForDelete { get; set; }

        public int OrderedBooksCount { get; set; }

        public int BooksOnHandsCount {  get; set; }

        public int BooksInDebtCount {  get; set; }

        public int Status {  get; set; }

        public int BooksCount { get; set; }

        public string ErrMessage {  get; set; }

        public StudentBiblio(Dictionary<string, object> dict)
        {
            FIO = (string)dict["Fio"];
            Pin = (string)dict["Pin"];
            Code = (string)dict["Code"];
            Email = (string)dict["Email"];
            Employment = (string)dict["Employment"];
            Course = (string)dict["Course"];
            Cost1 = (string)dict["Cost1"];
            Notes = (string)dict["Notes"];
            IsBlocked = (string)dict["Custom1"];
            IsReadyForDelete = (string)dict["Custom2"];
            OrderedBooksCount = (int)dict["Cntorders"];
            BooksOnHandsCount = (int)dict["Cntonhand"];
            BooksInDebtCount = (int)dict["Cntredate"];
            Status = (int)dict["Status"];
            ErrMessage = (string)dict["ErrMessage"];
        }
    }
}
