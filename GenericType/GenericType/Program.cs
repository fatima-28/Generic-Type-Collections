using System;
using System.Collections.Generic;


namespace GenericType.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection Lang1 = new Collection("C#", 2000);
            Collection Lang2 = new Collection("Java", 1995);
            Collection Lang3 = new Collection("Phyton", 1998);
            Collection Lang4 = new Collection("Pascal", 1950);

            List<Collection> languages = new List<Collection>() { };
            languages.Sort(delegate (Collection first, Collection second) {
                return first.Date.CompareTo(second.Date);
            });//date ye gore

            Console.WriteLine(languages);

            languages.Sort(delegate (Collection first, Collection second) {
                return first.Name.CompareTo(second.Name);//ada gore
            });

            Console.WriteLine(languages);

            //  1.Bir collection yaradırsız, içərisinə proqramlaşdırma
            //dillərini və yaradıldığı tarixləri daxil edirsiz.İlk
            //olaraq proqramlaşdırma dilləri   ilə(yeni yarandighi tarixe gore)
            //görə, sonra isə adlarına görə sıralansın
        }
    }
    public class Collection
    {
        public string Name { get; set; }
        public int Date { get; set; }

        public Collection(string name, int date)
        {
            Name = name;
            Date = date;
        }

        public override string ToString()
        {
            return $"Name:{Name},Date:{Date}";
        }
    }

}
