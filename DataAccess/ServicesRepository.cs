﻿using SpyDuh_Baratheon.Models;

namespace SpyDuh_Baratheon.DataAccess
{
    public class ServicesRepository
    {
        public List<Services> _servicesOffered = new List<Services>()
        {
            new Services()
            {
                ServiceId = 1,
                ServiceDetails = "Wiretapping Phones"
            },
            new Services()
            {
                ServiceId = 2,
                ServiceDetails = "Dodging Lazers"
            },
            new Services()
            {
                ServiceId = 3,
                ServiceDetails = "Drinking Martinis"
            },
            new Services()
            {
                ServiceId = 4,
                ServiceDetails = "Absurd acts of bravery in the face of certain defeat"
            },
            new Services()
            {
                ServiceId = 5,
                ServiceDetails = "Counter Espionage"
            },
            new Services()
            {
                ServiceId = 6,
                ServiceDetails = "Setting a Honeypot"
            },
        };

        internal List<Services> GetAll()
        {
            return _servicesOffered;
        }
    }
}
