using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string autor, string title, decimal price)
        {
            this.Author = autor;
            this.Title = title;
            this.Price = price;
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                title = value;
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                string[] name = value.Split();
                if (name.Length > 1)
                {
                    string secondName = name[1];
                    if (Char.IsDigit(secondName[0]))
                    {
                        throw new ArgumentException("Author not valid!");
                    }

                    author = value;
                }
            }
        }

        public virtual decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                price = value;
            }
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
                .AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .AppendLine($"Price: {this.Price:f2}");

            string result = resultBuilder.ToString().TrimEnd();
            return result;

        }
    }
}
