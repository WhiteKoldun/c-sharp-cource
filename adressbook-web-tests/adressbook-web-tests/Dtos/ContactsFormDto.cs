using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressbook_web_tests.Dtos
{
    class ContactsFormDto
    {
        public string Firstname { get; set; } = "first name text";
        public string Middlename { get; set; } = "middle name text";
        public string Lastname { get; set; } = "last name text";
        public string Nickname { get; set; } = "nickname text";
        public string Title { get; set; } = "title text";
        public string Company { get; set; } = "company text";
        public string Address { get; set; } = "adress text";
        public string Home { get; set; } = "11111";
        public string Mobile { get; set; } = "22222";
        public string Work { get; set; } = "33333";
        public string Fax { get; set; } = "44444";
        public string Email { get; set; } = "emai1l@mail.com";
        public string Email2 { get; set; } = "email2@mail.com";
        public string Email3 { get; set; } = "email3@mail.com";
        public string Homepage { get; set; } = "homepage.ru";
        public DateTime DateBirth { get; set; } = DateTime.Parse("02.02.2021");
        public DateTime DateA { get; set; } = DateTime.Parse("03.03.2021");
        public string BMonth { get; set; } = "February";
        public string AMonth { get; set; } = "February";
        public string Address2 { get; set; } = "secondary adress text";
        public string Phone2 { get; set; } = "sec homeaddress text";
        public string Notes { get; set; } = "notes text";
    }
}