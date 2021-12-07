using System;

namespace RestaurantAPI.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string mesage) : base(mesage)
        {
             
        }
    }
}
