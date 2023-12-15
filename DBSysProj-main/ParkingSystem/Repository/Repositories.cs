using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingSystem.Appdata;

namespace ParkingSystem.Repository
{
    public class Repositories
    {
        private ParkingSystemEntities db;

        public Repositories()
        { 
            db = new ParkingSystemEntities();
        }

        public List<Reservation> reserv1()
        {
            using (db = new ParkingSystemEntities())
            {
                return db.Reservation.ToList();
            }
        }
        public List<vw_Slots> getSlot()
        {
            using (db = new ParkingSystemEntities())
            { 
                return db.vw_Slots.ToList();
            }
        }
        public List<Vehicle> vehicle()
        {
            using (db = new ParkingSystemEntities())
            {
                return db.Vehicle.ToList();
            }
        }

        public Users GetUserByUsername(String username)
        {
            using (var db = new ParkingSystemEntities())
            {
                return db.Users.Where(m => m.userName == username).FirstOrDefault();
            }
        }
    }
}
