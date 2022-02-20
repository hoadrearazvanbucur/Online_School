using Online_School.Model;
using Online_School.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Online_School.Services
{
    public class EnrolementServices
    {
        public EnrolementRepository control;

        public EnrolementServices()
        {
            this.control = new EnrolementRepository();
        }

        public List<Enrolement> lista()
        {
            return control.getAll();
        }

        public void create(Enrolement enrolement)
        {
            if (!this.lista().Contains(enrolement))
            {
                control.add(enrolement);
            }
            else
            {
                throw new Exception("");
            }
        }

        public void deleteById(int id)
        {
            if (this.lista().Contains(this.control.getEnrolementById(id)))
            {
                control.deleteById(id);
            }
            else
            {
                throw new Exception("");
            }
        }
    }
}
