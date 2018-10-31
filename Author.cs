using System;

namespace CIDM3312Midterm
{
    public class Author
    {
        public int AuthorID { get; set; } 
        public string AuthorFName { get; set; }
        public string AuthorLName { get; set; }

        public override string ToString(){
            return this.AuthorID + " - " + this.AuthorFName + this.AuthorLName;
        }
    }
}