using HospitalManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementTests
{
    [TestFixture]
    public class DoctorTests
    {
        [Test]
        public void Doctor_Constructor_ShouldSetAllProperties()
        {
            var doctor = new Doctor(1, "Андрій Андріїч", "Терапевт");

            Assert.AreEqual(1, doctor.Id);
            Assert.AreEqual("Андрій Андріїч", doctor.Name);
            Assert.AreEqual("Терапевт", doctor.Specialization);
        }

        [Test]
        public void Doctor_Properties_CanBeModified()
        {
            var doctor = new Doctor(1, "Микола Миколаїч", "Терапевт");

            doctor.Id = 2;
            doctor.Name = "Микола Миколаїч";
            doctor.Specialization = "Хірург";

            Assert.AreEqual(2, doctor.Id);
            Assert.AreEqual("Петров Петро", doctor.Name);
            Assert.AreEqual("Хірург", doctor.Specialization);
        }

        [Test]
        public void Doctor_CanCreateMultipleDoctors()
        {
            var doctor1 = new Doctor(1, "Іванов Іван", "Терапевт");
            var doctor2 = new Doctor(2, "Петрова Марія", "Хірург");

            Assert.AreNotEqual(doctor1.Id, doctor2.Id);
            Assert.AreNotEqual(doctor1.Name, doctor2.Name);
        }
    }
}
