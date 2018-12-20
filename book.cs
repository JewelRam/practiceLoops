namespace MediaTypes
{
    class book : MediaTypes
    {
        public string Author;
       

        public book(string title, string author) 
        : base(title)
        {
            Author = author;
        }
      
        public string GetDisplayText()
        {
            string text = "Book Title: " + Title + "by: " + Author;
            if (Borrowed)
            {
                if (!string.IsNullOrEmpty(Loanee))
                {
                text += "(Currently Borrowed by: " + Loanee + ")";
                } else {
                    text = text += "(Currently Borrowed)";
                }
            }
            return text;
        }
    }
}