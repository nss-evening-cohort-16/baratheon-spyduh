﻿using SpyDuh_Baratheon.Models;

namespace SpyDuh_Baratheon.DataAccess
{
    public class ServicesRepository
    {
        public List<Service> _servicesOffered = new List<Service>()
        {
            new Service()
            {
                ServiceId = 1,
                ServiceDetails = "Wiretapping Phones"
            },
            new Service()
            {
                ServiceId = 2,
                ServiceDetails = "Dodging Lazers"
            },
            new Service()
            {
                ServiceId = 3,
                ServiceDetails = "Drinking Martinis"
            },
            new Service()
            {
                ServiceId = 4,
                ServiceDetails = "Absurd acts of bravery in the face of certain defeat"
            },
            new Service()
            {
                ServiceId = 5,
                ServiceDetails = "Counter Espionage"
            },
            new Service()
            {
                ServiceId = 6,
                ServiceDetails = "Setting a Honeypot"
            },
        };

        internal Service GetServiceById(int id)
        {
            var match = _servicesOffered.FirstOrDefault(i => i.ServiceId == id);
            return match;
        }

        internal void Post(Service newService)
        {
            _servicesOffered.Add(newService);
        }

        internal List<Service> GetAll()
        {
            return _servicesOffered;
        }
    }
}
