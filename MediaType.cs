using System;
namespace MediaTypes
{
    class MediaTypes
    {
        public string Title;
         public string Loanee;
        public bool Borrowed;

        public MediaTypes(string title)
        {
            if(string.IsNullOrEmpty(title))
            {
              throw new Exception("A media type must have a title!");  
            }
            Title = title;
        }
          public void Loan() 
        {
            Borrowed = true;
        }
        public void Loan(string loanee )
        {
            Loanee = loanee;
            Loan();
        }
        public void Return()
        {
            Loanee = null;
            Borrowed = false;
        }
    }
}