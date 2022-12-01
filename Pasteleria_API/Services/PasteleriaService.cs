using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Pasteleria_API.Models;

namespace Pasteleria_API.Services
{
    public class PasteleriaService
    {
        private IMongoCollection<Usuarios> _usuarios;

        public PasteleriaService(IPasteleriaSettings settings)
        {
            var cliente = new MongoClient(settings.Server);
            var database = cliente.GetDatabase(settings.Database);
            _usuarios = database.GetCollection<Usuarios>(settings.Collection);
        }

        public List<Usuarios> Get()
        {
            return _usuarios.Find(id => true).ToList();
        }
        public Usuarios Create(Usuarios usuarios)
        {
            _usuarios.InsertOne(usuarios);
            return usuarios;
        }
        public void Update(string id, Usuarios usuarios)
        {
            _usuarios.ReplaceOne(usuarios => usuarios.Id == id, usuarios);
        }
        public void Delete(string id)
        {
            _usuarios.DeleteOne(d => d.Id == id);
        }
    }
}
