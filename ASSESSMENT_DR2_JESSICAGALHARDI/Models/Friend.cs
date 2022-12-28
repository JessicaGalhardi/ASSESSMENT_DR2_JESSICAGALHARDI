using FriendXY.Controllers;
using System;

namespace FriendXY.Models
{
    public class Friend
    {
      

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }

        public DateTime BirthDate { get; set; }


        public string Birthday
        {
            get
            {

                return BirthDate.ToString("dd. MM");

            }

        }


    }
}



