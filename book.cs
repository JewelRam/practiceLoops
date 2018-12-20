namespace MediaTypes
{
    class book
    {
        public string Title;
        public string Author;
        public string Loanee;
        public bool Borrowed;

        public book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public void Loan(string loanee )
        {
            Loanee = loanee;
            Borrowed = true;
        }
        public void Return()
        {
            Loanee = null;
            Borrowed = false;
        }
        public string GetDisplayText()
        {
            string text = "Book Title: " + Title + "by: " + Author;
            if (Borrowed)
            {
                text += "(Currently Borrowed by: " + Loanee + ")";
            }
            return text;
        }
    }
}