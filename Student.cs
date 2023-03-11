using System;
using System.Net;
using System.Xml.Linq;

namespace HW07_03_23_classes_overviwe
{
    public class Student
    {
        private string name;
        private string lastname;
        private string surname;
        private string phoneNumber;
        DateTime birthday;
        Address address;

        List<double> offsets = new List<double>();
        List<double> hometasks = new List<double>();
        List<double> exams = new List<double>();

        public Student(string name, string lastname, string surname, DateTime birthday, string phoneNumber, string city, string street, string homeNumber)
        {
            setName(name);
            setLastname(lastname);
            setSurname(surname);
            setPhoneNumber(phoneNumber);
            setBirthday(birthday);
            setAddress(city, street, homeNumber);
            fillingLists();
        }

        public Student(string name, string lastname, string surname, DateTime birthday, string phoneNumber) :
            this(name, lastname, surname, birthday, phoneNumber, "None", "None", "None")
        { }

        public Student(string name, string lastname, string surname) :
            this(name, lastname, surname, new DateTime(1, 1, 1), "+38**********", "None", "None", "None")
        { }

        public Student() :
            this("None", "None", "None", new DateTime(1, 1, 1), "+38**********", "None", "None", "None")
        { }

        public void setName(string name) { this.name = name; }
        public void setLastname(string lastname) { this.lastname = lastname; }
        public void setSurname(string surname) { this.surname = surname; }
        public void setPhoneNumber(string phoneNumber) { this.phoneNumber = phoneNumber; }
        public void setBirthday(DateTime birthday) { this.birthday = birthday; }
        public void setAddress(string city, string street, string homeNumber) { this.address = new Address(city, street, homeNumber); }

        public string getName() { return this.name; }
        public string getLastname() { return this.lastname; }
        public string getSurname() { return this.surname; }
        public string getPhoneNumber() { return this.phoneNumber; }
        public DateTime getBirthday() { return this.birthday; }
        public Address getAddress() { return this.address; }

        public void fillingLists()
        {
            for (int i = 0; i < 7; ++i)
            {
                offsets.Add(new Random().Next(1, 13));
                hometasks.Add(new Random().Next(1, 13));
                exams.Add(new Random().Next(1, 13));
            }
        }

        public string getListOffsets() { return string.Join(" ", this.offsets); }
        public string getListHometasks() { return string.Join(" ", this.hometasks); }
        public string getListExams() { return string.Join(" ", this.exams); }

        public override string ToString()
        {
            return ($"Student: {getName()} {getLastname()} {getSurname()}\n" +
                $"Birthday: {getBirthday()}\n" +
                $"Address: {getAddress()}\n" +
                $"Phone number: {getPhoneNumber()}\n" +
                $"Rating\n" +
                $"Scores offsets - {getListOffsets()}\n" +
                $"Scores hometasks - {getListHometasks()}\n" +
                $"Scores exams - {getListExams()}\n");
        }
    }
}
