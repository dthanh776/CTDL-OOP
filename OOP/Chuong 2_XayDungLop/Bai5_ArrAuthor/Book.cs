using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong2_Bai5
{
    public class Book
    {
        private string name;
        private Author[] author;
        private double price;
        private int qty;

        public Book (string name, Author[] author ,double price)
        {
            this.name = name;
            this.author = author;
            this.price = price;
        }
        public string getname()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public double getPrice()
        {
            return price;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }

        public int getQty()
        {
            return qty;
        }
        public void setQty(int qty)
        {
            this.qty = qty;
        }
        public string getAuthorNames()
        {
            string authorName = "";
            for (int i = 0; i < author.Length -1 ; i++)
            {
                authorName += author[i].getName();
            }
            authorName += author[author.Length - 1].getName();
            return authorName;
        }
        public string toString()
        {
            string str = "";
            str = $"{getname()} {getAuthorNames()}{getPrice()}";
            return str;
        }
    }
}
