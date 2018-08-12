using ParcialIX.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;




namespace ParcialIX.Controllers
{
    public class AlumnosController : ApiController
    {
        AprograIX[] alum = new AprograIX[]
        {
              new AprograIX{Id_alumnos=1,Nombre="Andersson",Apellido="Hernandez",Telefono=2435},
              new AprograIX{Id_alumnos=2,Nombre="Emerson",Apellido="Sotoy",Telefono=324342},
              new AprograIX{Id_alumnos=3,Nombre="",Apellido="Perez",Telefono=452342},
              new AprograIX{Id_alumnos=4,Nombre="Ronaldop",Apellido="Joton",Telefono=532452},
              new AprograIX{Id_alumnos=5,Nombre="Harris",Apellido="Blanco",Telefono=524352},
              new AprograIX{Id_alumnos=6,Nombre="Estefania",Apellido="Cunay",Telefono=523452},
              new AprograIX{Id_alumnos=7,Nombre="Oscar",Apellido="Rodolfo",Telefono=23542},
              new AprograIX{Id_alumnos=8,Nombre="Dayana",Apellido="Hernandez",Telefono=23452},
              new AprograIX{Id_alumnos=9,Nombre="Ruben",Apellido="Sotoy",Telefono=234523452},
              new AprograIX{Id_alumnos=10,Nombre="Soy",Apellido="Hernandez",Telefono=2354232},
              new AprograIX{Id_alumnos=11,Nombre="Sotoy",Apellido="Sotoy",Telefono=23452},
              new AprograIX{Id_alumnos=12,Nombre="Vanesa",Apellido="Hernandez",Telefono=23452},
              new AprograIX{Id_alumnos=13,Nombre="Oscar",Apellido="Hernandez",Telefono=23452},
              new AprograIX{Id_alumnos=14,Nombre="Elsy",Apellido="Perez",Telefono=23452},
              new AprograIX{Id_alumnos=15,Nombre="Katla",Apellido="Sotoy",Telefono=23452},
              new AprograIX{Id_alumnos=16,Nombre="katy",Apellido="Martinez",Telefono=3452},
              new AprograIX{Id_alumnos=17,Nombre="Marica",Apellido="Hernandez",Telefono=3452},
              new AprograIX{Id_alumnos=18,Nombre="Josn",Apellido="Hernandez",Telefono=8972},
              new AprograIX{Id_alumnos=19,Nombre="Jeshua",Apellido="Hernandez",Telefono=97892},
              new AprograIX{Id_alumnos=20,Nombre="Oscar",Apellido="Hernandez",Telefono=7892},
              new AprograIX{Id_alumnos=21,Nombre="Heysi",Apellido="Hernandez",Telefono=7892},
              new AprograIX{Id_alumnos=22,Nombre="Vanesa",Apellido="Hernandez",Telefono=782},
              new AprograIX{Id_alumnos=23,Nombre="Andersson",Apellido="Hernandez",Telefono=34532},
              new AprograIX{Id_alumnos=24,Nombre="Perez",Apellido="Hernandez",Telefono=4652342},
              new AprograIX{Id_alumnos=25,Nombre="Vanesa",Apellido="Hernandez",Telefono=62342},
              new AprograIX{Id_alumnos=26,Nombre="Andersson",Apellido="Hernandez",Telefono=62342},
              new AprograIX{Id_alumnos=27,Nombre="Vanesa",Apellido="Hernandez",Telefono=562342},
              new AprograIX{Id_alumnos=28,Nombre="Vanesa",Apellido="Hernandez",Telefono=37452},
              new AprograIX{Id_alumnos=29,Nombre="Dayana",Apellido="Hernandez",Telefono=57342},
              new AprograIX{Id_alumnos=30,Nombre="Andersson",Apellido="Sotoy",Telefono=5672},
              new AprograIX{Id_alumnos=31,Nombre="Andersson",Apellido="Hernandez",Telefono=2},
              new AprograIX{Id_alumnos=32,Nombre="Dayana",Apellido="Sotoy",Telefono=2534},
              new AprograIX{Id_alumnos=33,Nombre="Oscar",Apellido="Hernandez",Telefono=24523},
              new AprograIX{Id_alumnos=34,Nombre="Andersson",Apellido="Sotoy",Telefono=2324532},
              new AprograIX{Id_alumnos=35,Nombre="Vanesa",Apellido="Hernandez",Telefono=897892},
              new AprograIX{Id_alumnos=36,Nombre="Andersson",Apellido="Sotoy",Telefono=89792},
              new AprograIX{Id_alumnos=37,Nombre="Oscar",Apellido="Hernandez",Telefono=897892},
              new AprograIX{Id_alumnos=38,Nombre="Andersson",Apellido="Hernandez",Telefono=879572},
              new AprograIX{Id_alumnos=39,Nombre="Andersson",Apellido="Hernandez",Telefono=32452},
              new AprograIX{Id_alumnos=40,Nombre="Oscar",Apellido="Hernandez",Telefono=3242},
              new AprograIX{Id_alumnos=41,Nombre="Andersson",Apellido="Hernandez",Telefono=457432},
              new AprograIX{Id_alumnos=42,Nombre="Estefania",Apellido="Hernandez",Telefono=47352},
              new AprograIX{Id_alumnos=43,Nombre="Oscar",Apellido="Hernandez",Telefono=342562},
              new AprograIX{Id_alumnos=44,Nombre="Estefania",Apellido="Hernandez",Telefono=5623562},
              new AprograIX{Id_alumnos=45,Nombre="Emerson",Apellido="Hernandez",Telefono=23245},
              new AprograIX{Id_alumnos=46,Nombre="Andersson",Apellido="Blacon",Telefono=23452},
              new AprograIX{Id_alumnos=47,Nombre="Emerson",Apellido="Maquey",Telefono=235423452},
              new AprograIX{Id_alumnos=48,Nombre="Estefania",Apellido="Hernandez",Telefono=6723452},
              new AprograIX{Id_alumnos=49,Nombre="Emerson",Apellido="Ana",Telefono=632462},
              new AprograIX{Id_alumnos=50,Nombre="Oscar",Apellido="Hernandez",Telefono=72452},
    };

        //private UDEOEntities db = new UDEOEntities();
        //public IQueryable<Alumnos> GetAllAlumnos(){
        //    return db.Alumnos;

        //}

            //Get: api/alumno
          public IEnumerable<AprograIX> GetAllAprograIX()
        {
            return alum;
        }

        //Get: api/alumno/id
        public IHttpActionResult GetCarro(int id)
        {
            var carro = alum.FirstOrDefault((c) => c.Id_alumnos == id);
            if (carro != null)
            {
                return Ok(carro);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
