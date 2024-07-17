using System;
using System.Collections.Generic;
namespace Project1_ContactNumbers
{
    public static class Contacts
    {
        public static List<ContactModel> liste = new List<ContactModel>{
            new ContactModel("Berk", "Akın", 111111111),
            new ContactModel("Cem", "Deniz", 22222222),
            new ContactModel("Anıl", "Davran", 33333333),
            new ContactModel("Selçuk", "Okur", 444444444),
            new ContactModel("Demir", "Yılmaz", 55555555),
        };
    }
}